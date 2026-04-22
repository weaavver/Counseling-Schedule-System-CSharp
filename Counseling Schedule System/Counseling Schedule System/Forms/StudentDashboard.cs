using Counseling_Schedule_System;
using Counseling_Schedule_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Counseling_Schedule_System.Forms
{
    public partial class StudentDashboard : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        private int? _userID; //added ? to allow null value for userID
        public StudentDashboard(int? userID)
        {
            InitializeComponent();
            _userID = userID;
            scheduledDateTime.Format = DateTimePickerFormat.Custom;
            scheduledDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            LoadRequest();
            PanelScheduleBoard.Visible = true;

            greet();
        }

        public void greet()
        {
            string sql = @"SELECT Concat(FirstName,' ' ,LastName) FROM studentTbl WHERE studentId = @studentId";

            string studentName = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@studentId", SqlDbType.Int).Value = _userID;

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            studentName = result.ToString();
                        }
                    }
                }
                lblGreet.Text = $"Hello, {studentName}!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadRequest()
        {
            string sql = @"SELECT CreatedAt, ScheduledDateTime, CounselorID, Status
                   FROM requestTbl
                   WHERE StudentID = @StudentID AND Status = 'Pending'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = _userID;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dateRequested = reader["CreatedAt"].ToString();
                                string counselor = reader["CounselorID"].ToString();
                                string status = reader["Status"].ToString();

                                txtDateRequested.Text = dateRequested;
                                if (reader["ScheduledDateTime"] != DBNull.Value)
                                {
                                    scheduledDateTime.Format = DateTimePickerFormat.Custom;
                                    scheduledDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
                                    scheduledDateTime.Value = Convert.ToDateTime(reader["ScheduledDateTime"]);
                                }
                                else
                                {
                                    scheduledDateTime.CustomFormat = " "; // shows blank
                                }
                                if (counselor == "0")
                                    txtCounselor.Text = "Not Assigned";
                                else
                                    txtCounselor.Text = counselor;
                                txtStatus.Text = status;

                                PanelScheduleBoard.Visible = true;
                                }
                            else
                            {
                                txtDateRequested.Text = "----";
                                txtCounselor.Text = "----";
                                txtStatus.Text = "----";
                                scheduledDateTime.CustomFormat = " "; // shows blank
                                PanelScheduleBoard.Visible = false;
                            }    
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedule: " + ex.Message);
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to perform this action? Warning: You cannot cancel a schedule once it's confirmed.", 
                "Confirmation",                                 
                MessageBoxButtons.YesNo,                        
                MessageBoxIcon.Question                         
                );

                if (result == DialogResult.Yes)
                {
                    if (richTxtReason.Text == "")
                    {
                        MessageBox.Show("Please provide a reason for your request.");
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            string checkSql = @"SELECT COUNT(*) FROM requestTbl 
                            WHERE StudentID = @StudentID AND Status = 'Pending'";

                            using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                            {
                                checkCmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = _userID;

                                int pendingCount = (int)checkCmd.ExecuteScalar();

                                if (pendingCount > 0)
                                {
                                    MessageBox.Show("You already have a pending request. Please wait until it is processed.");
                                    return;
                                }
                            }

                            DateTime finalDateTime = DatePicker.Value.Date + TimePicker.Value.TimeOfDay;

                            string insertSql = @"INSERT INTO requestTbl (StudentID, PreferredDateTime, Reason)
                             VALUES (@StudentID, @PreferredDateTime, @Reason)";

                            using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                            {
                                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = _userID;
                                cmd.Parameters.Add("@PreferredDateTime", SqlDbType.DateTime2).Value = finalDateTime;
                                cmd.Parameters.Add("@Reason", SqlDbType.NVarChar, 500).Value = richTxtReason.Text;

                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Request submitted! Wait for an email for further notice");
                        LoadRequest();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting request: " + ex.Message);
            }
        }
    

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTxtReason.Text = "";
        }

        private void PanelScheduleBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblGreet_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequest();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            try
            {
                if (txtDateRequested.Text.Equals("----"))
                {
                    MessageBox.Show("No pending request to cancel.");
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                    "Are you sure you want to Cancel your currently pending request?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            SqlCommand cmd = new SqlCommand(@"
                            UPDATE requestTbl
                            SET Status = 'Cancelled',
                                UpdatedAt = GETDATE()
                            WHERE StudentID = @StudentID
                            AND Status = 'Pending';"
                            , conn);

                            DateTime DatetTimecombined = DatePicker.Value.Date + TimePicker.Value.TimeOfDay;

                            cmd.Parameters.AddWithValue("@studentID", _userID);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        MessageBox.Show("Pending request cancelled.");
                        LoadRequest();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error submitting request: " + ex.Message);
            }
        
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                _userID = null; //reset the userID to null
                StudentLogin login = new StudentLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
