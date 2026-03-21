using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Counseling_Schedule_System.Forms
{
    public partial class CounselorDashboard : Form
    {
        string connectionString =
        @"Data Source=DESKTOP-IRCI6E2;Initial Catalog=CounselingScheduleSystem;Integrated Security=True;Encrypt=False;";
        private int _userID;
        public CounselorDashboard(int userID)
        {
            InitializeComponent();
            _userID = userID;     
            RefreshSchedule();
            RefreshRequests();


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
                    SqlDataAdapter sqlDa = new SqlDataAdapter
                    ("SELECT \r\n    r.requestID,\r\n    s.StudentName,\r\n    c.CounselorName,\r\n    s.MobileNo,\r\n    s.Email\r\nFROM requestTbl r\r\nINNER JOIN studentTbl s \r\n    ON r.StudentID = s.studentID\r\nINNER JOIN counselorTbl c \r\n    ON r.CounselorID = c.counselorID\r\nWHERE r.[Status] = 'Scheduled'\r\nAND r.CounselorID = @counselorID;", sqlCon);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@counselorID", _userID);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvSchedules.ReadOnly = true;
                    dgvSchedules.DataSource = dtbl;
                }
            }
            catch(Exception ex)
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
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();

                        string query = @"SELECT r.*,
                             s.StudentName
                             FROM requestTbl r
                             JOIN studentTbl s ON r.StudentID = s.studentID
                             JOIN counselorTbl c ON c.counselorID = @counselorID
                             WHERE r.Status = 'Pending'
                             AND s.Gender = c.Gender";

                        SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
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
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
            panel1.ClientRectangle,
            Color.LightSkyBlue,
            Color.White,
            90F))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtRequestID.Text == "")
            {
                MessageBox.Show("Please select a request to schedule.", "No Request Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string requestID = txtRequestID.Text;
                string status = "Scheduled";
                DateTime scheduledDate = DatePicker.Value.Date;
                TimeSpan scheduledTime = TimePicker.Value.TimeOfDay;

                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter
                        ("UPDATE requestTbl " +
                        "SET counselorID = @counselorID, " +
                        "ScheduledDate = @scheduledDate, " +
                        "ScheduledTime = @scheduledTime, " +
                        "[Status] = @status, " +
                        "UpdatedAt = GETDATE() " +
                        "WHERE requestID = @requestID", sqlCon);

                        sqlDa.SelectCommand.Parameters.AddWithValue("@counselorID", _userID);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@requestID", requestID);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@scheduledDate", scheduledDate);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@scheduledTime", scheduledTime);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@status", status);

                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);

                        dgvSchedules.DataSource = dtbl;
                    }
                }
                catch(Exception ex)
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
            Update("Completed");
        }

        private void Update(string Status)
        {
            if (txtRequestID2.Text == "")
            {
                MessageBox.Show("Please sekect an ID", "No Schedule Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string requestID = txtRequestID2.Text; //for schedule
                string status = Status;

                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter
                        ("UPDATE requestTbl " +
                        "[Status] = @status, " +
                        "UpdatedAt = GETDATE() " +
                        "WHERE requestID = @requestID", sqlCon);

                        sqlDa.SelectCommand.Parameters.AddWithValue("@counselorID", _userID);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@requestID", requestID);
                        sqlDa.SelectCommand.Parameters.AddWithValue("@status", status);

                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);

                        dgvSchedules.DataSource = dtbl;
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

        private void TakeRequest(int requestID) //GENERATED
        {
            string status = "Scheduled";
            DateTime scheduledDate = DatePicker.Value.Date;
            TimeSpan scheduledTime = TimePicker.Value.TimeOfDay;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand(
                "UPDATE requestTbl " +
                "SET counselorID = @counselorID, " +
                "ScheduledDate = @scheduledDate, " +
                "ScheduledTime = @scheduledTime, " +
                "[Status] = @status, " +
                "UpdatedAt = GETDATE() " +
                "WHERE requestID = @requestID", sqlCon);

                cmd.Parameters.AddWithValue("@counselorID", _userID);
                cmd.Parameters.AddWithValue("@requestID", requestID);
                cmd.Parameters.AddWithValue("@scheduledDate", scheduledDate);
                cmd.Parameters.AddWithValue("@scheduledTime", scheduledTime);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Request successfully scheduled!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRequestRefresh_Click(null, null); // refresh table
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e) //GENERATED
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            Update("Cancelled");
        }

        private void dgvSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
            dgvSchedules.Rows[e.RowIndex].Cells["requestID"].Value != null)
            {
                int requestID = Convert.ToInt32(
                    dgvSchedules.Rows[e.RowIndex].Cells["requestID"].Value
                );

                DialogResult result = MessageBox.Show(
                    "Yes = Complete\nNo = Cancel Schedule",
                    "Complete Or Cancel",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                        string status = "Completed";
                        try
                        {
                            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                            {
                                sqlCon.Open();
                                SqlDataAdapter sqlDa = new SqlDataAdapter
                                ("UPDATE requestTbl " +
                                "SET [Status] = @status, " +
                                "UpdatedAt = GETDATE() " +
                                "WHERE requestID = @requestID", sqlCon);

                                sqlDa.SelectCommand.Parameters.AddWithValue("@counselorID", _userID);
                                sqlDa.SelectCommand.Parameters.AddWithValue("@requestID", requestID);
                                sqlDa.SelectCommand.Parameters.AddWithValue("@status", status);

                                DataTable dtbl = new DataTable();
                                sqlDa.Fill(dtbl);

                                dgvSchedules.DataSource = dtbl;

                                RefreshSchedule();
                                MessageBox.Show("Schedule marked as completed!", "Success",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (result == DialogResult.Cancel)
                {
                    string status = "Cancelled";
                    try
                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter
                            ("UPDATE requestTbl " +
                            "SET [Status] = @status, " +
                            "UpdatedAt = GETDATE() " +
                            "WHERE requestID = @requestID", sqlCon);

                            sqlDa.SelectCommand.Parameters.AddWithValue("@counselorID", _userID);
                            sqlDa.SelectCommand.Parameters.AddWithValue("@requestID", requestID);
                            sqlDa.SelectCommand.Parameters.AddWithValue("@status", status);

                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);

                            dgvSchedules.DataSource = dtbl;
                            RefreshSchedule();

                            MessageBox.Show("Schedule cancelled!", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
