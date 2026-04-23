using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Forms
{
    public partial class CounselorDashboard : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        private int? _userID;
        public CounselorDashboard(int? userID)
        {
            InitializeComponent();
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pnlSchedule.Visible = false; 
            _userID = userID;
            RefreshSchedule(); //refresh scheule table
            RefreshRequests(); //refresh request table
            AutoCancelOldRequests(); //self explanatory
            greet();
        }

        public void greet()
        {
            string sql = @"SELECT FirstName + ' ' + LastName AS 'Counselor Name' FROM counselorTbl WHERE counselorID = @counselorID";

            string counselorName = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@counselorID", SqlDbType.Int).Value = _userID;

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            counselorName = result.ToString();
                        }
                    }
                }
                lblGreet.Text = $"Hello, {counselorName}!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnScheduleRefresh_Click(object sender, EventArgs e)
        {
            RefreshSchedule();
        }

        private void RefreshSchedule()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        r.requestID,
                        (s.FirstName + ' ' + s.LastName) AS Name,
                        (c.FirstName + ' ' + c.LastName) AS CounselorName,
                        s.MobileNo,
                        s.Email,
                        r.ScheduledDateTime  -- CHANGED: added scheduled datetime
                    FROM requestTbl r
                    INNER JOIN studentTbl s 
                        ON r.StudentID = s.studentID
                    INNER JOIN counselorTbl c 
                        ON r.CounselorID = c.counselorID
                    WHERE r.[Status] = 'Scheduled'
                    AND r.CounselorID = @counselorID;", sqlCon);

                    SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@counselorID", _userID);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvSchedules.AllowUserToAddRows = false; // Removes the last row that spawns along with dgv
                    dgvSchedules.ReadOnly = true;
                    dgvSchedules.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedules.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void RefreshRequests()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand(@"
                        SELECT 
                        CONCAT(s.FirstName, ' ', s.LastName) AS Name,
                        r.requestID,
                        r.PreferredDateTime,
                        r.Reason AS Issue,
                        r.[Status],
                        r.CreatedAt
                        FROM requestTbl r
                        JOIN studentTbl s ON r.StudentID = s.studentID
                        JOIN counselorTbl c ON c.counselorID = @counselorID
                        WHERE r.Status = 'Pending'
                        AND s.Gender = c.Gender", sqlCon);

                    SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@counselorID", _userID);

                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvRequests.AllowUserToAddRows = false; // Removes the last row that spawns along with dgv
                    dgvRequests.ReadOnly = true;
                    dgvRequests.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btnRequestRefresh_Click(object sender, EventArgs e)
        {
            RefreshRequests();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmRequest();
            RefreshSchedule();
            RefreshRequests();
            selectedRequestID = null; 
        }

        private void ConfirmRequest() //Confirming pending requests
        {
            if (!selectedRequestID.HasValue)
            {
                MessageBox.Show("Please select a request to schedule.", "No Request Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to confirm this request?", "Confirmation", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            else
            {
                string status = "Scheduled";
                DateTime scheduledDate = DatePicker.Value.Date;
                TimeSpan scheduledTime = TimePicker.Value.TimeOfDay;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(@"
                        BEGIN TRY
                            BEGIN TRANSACTION;

                            UPDATE requestTbl
                            SET counselorID = @counselorID, 
                                ScheduledDateTime = @ScheduledDateTime, 
                                [Status] = @status, 
                                UpdatedAt = GETDATE()
                            WHERE requestID = @requestID;

                            IF @@ROWCOUNT = 0
                            BEGIN
                                THROW 50007, 'Update failed. Request not found.', 1;
                            END

                            COMMIT TRANSACTION;
                        END TRY
                        BEGIN CATCH
                            ROLLBACK TRANSACTION;
                            THROW;
                        END CATCH;", conn);

                        DateTime DateTimeCombined = DatePicker.Value.Date + TimePicker.Value.TimeOfDay;

                        cmd.Parameters.AddWithValue("@counselorID", _userID);
                        cmd.Parameters.AddWithValue("@requestID", selectedRequestID.Value);
                        cmd.Parameters.AddWithValue("@ScheduledDateTime", DateTimeCombined);
                        cmd.Parameters.AddWithValue("@status", status);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("No record was updated. Check requestID.");
                        }
                        else
                        {
                            MessageBox.Show("Request scheduled successfully!");
                        }

                        conn.Close();


                        string email = GetStudentEmail(selectedRequestID.Value);

                        SendEmail( //Send email to notify
                            email,
                            "Counseling Scheduled",
                            $"Your counseling has been scheduled on {DateTimeCombined}"
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading requests.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRequestID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNotes.Text == "")
            {
                return;
            }
            Update("Completed");
            RefreshSchedule();
            selectedScheduleID = null;
        }

        private void Update(string Status)
        {
            if (!selectedScheduleID.HasValue)
            {
                MessageBox.Show("Please select an ID", "No Schedule Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            else
            {

                string status = Status;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(@"
                        BEGIN TRY
                            BEGIN TRANSACTION;

                            UPDATE requestTbl
                            SET [Status] = @status,
                                CounselingNotes = @CounselingNotes,
                                UpdatedAt = GETDATE()
                            WHERE requestID = @requestID;

                            IF @@ROWCOUNT = 0
                            BEGIN
                                THROW 50008, 'Update failed. Request not found.', 1;
                            END

                            COMMIT TRANSACTION;
                        END TRY
                        BEGIN CATCH
                            ROLLBACK TRANSACTION;
                            THROW;
                        END CATCH;", conn);

                        cmd.Parameters.AddWithValue("@counselorID", _userID);
                        cmd.Parameters.AddWithValue("@requestID", selectedScheduleID.Value);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@CounselingNotes", txtNotes.Text);

                        cmd.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Sucessfully " + status);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading requests.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }
        }

        private void lblGreet_Click(object sender, EventArgs e)
        {

        }

        private int? selectedRequestID;
        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRequestID = Convert.ToInt32(
                    dgvRequests.Rows[e.RowIndex].Cells["requestID"].Value
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!selectedScheduleID.HasValue)
            {
                MessageBox.Show("Please select a schedule first.");
                return;
            }

            Update("Cancelled");
            RefreshSchedule();

            string email = GetStudentEmail(selectedScheduleID.Value);

            SendEmail(
                email,
                $"Counseling Cancelled",
                $"Your counseling session has been marked as Cancelled."
            );

            selectedScheduleID = null;
        }

        private void dgvSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private int? selectedScheduleID;

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("counselingguidanceoffice@gmail.com");
                msg.To.Add(toEmail);
                msg.Subject = subject;
                msg.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("counselingguidanceoffice@gmail.com", "epqrpcohttikqgkh");
                smtp.EnableSsl = true;

                smtp.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send the mail:\n" + ex.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private string GetStudentEmail(int ID)
        {
            string email = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT s.Email
            FROM requestTbl r
            INNER JOIN studentTbl s ON r.StudentID = s.studentID
            WHERE r.requestID = @ID", conn);

                cmd.Parameters.AddWithValue("@ID", ID);

                object result = cmd.ExecuteScalar();
                if (result != null)
                    email = result.ToString();
            }

            return email;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                _userID = null; //reset the userID to null
                CounselorLogin login = new CounselorLogin();
                login.Show();
                this.Hide();
            }
        }

        private void txtPending_TextChanged(object sender, EventArgs e)
        {}

        private void AutoCancelOldRequests()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string sql = @"
                        UPDATE requestTbl
                        SET Status = 'Cancelled',
                            UpdatedAt = GETDATE()
                        WHERE Status IN ('Pending', 'Scheduled')
                          AND CreatedAt <= DATEADD(DAY, -30, GETDATE())";

                            using (SqlCommand cmd = new SqlCommand(sql, conn, tran))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error auto-cancelling old requests:\n" + ex.Message);
            }
        }

        private void btnShowRequests_Click(object sender, EventArgs e)
        {
            pnlSchedule.Visible = false;
            pnlRequests.Visible = true;
        }

        private void btnShowSchedule_Click(object sender, EventArgs e)
        {
            pnlSchedule.Visible = true;
            pnlRequests.Visible = false;
        }

        

        private void dgvSchedules_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedScheduleID = Convert.ToInt32(
                    dgvSchedules.Rows[e.RowIndex].Cells["requestID"].Value
                );
            }
        }
    }
}    