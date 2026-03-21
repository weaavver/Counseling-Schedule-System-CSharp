using Counseling_Schedule_System.Models;
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
using System.Xml.Linq;

namespace Counseling_Schedule_System.Forms
{
    public partial class StudentDashboard : Form
    {
        string connectionString = @"Data Source=DESKTOP-IRCI6E2;Initial Catalog=CounselingScheduleSystem;
        Integrated Security=True;Encrypt=False;";
        private int _userID;
        public StudentDashboard(int userID)
        {
            InitializeComponent();
            _userID = userID;
            RoundedCorners(25);
            LoadRequest();

            string sql = @"SELECT StudentName FROM studentTbl WHERE studentID = @StudentID";

            string studentName = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = _userID;

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

        public void RoundedCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();

            this.Region = new Region(path);
        }

        private void LoadRequest()
        {
            string sql = @"SELECT CreatedAt, PreferredDateTime, CounselorID, Status
                   FROM requestTbl
                   WHERE StudentID = @StudentID AND Status = 'Pending' AND Status = 'Cancelled'";

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
                                string preferredTime = reader["PreferredDateTime"].ToString();
                                string counselor = reader["CounselorID"].ToString();
                                string status = reader["Status"].ToString();

                                txtDateRequested.Text = dateRequested;
                                txtScheduledTime.Text = preferredTime;
                                if(counselor == "0")
                                    txtCounselor.Text = "Not Assigned";
                                else
                                    txtCounselor.Text = counselor;
                                txtStatus.Text = status;

                                PanelScheduleBoard.Visible = true;
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
                "Are you sure you want to perform this action?", 
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
            using (LinearGradientBrush brush = new LinearGradientBrush(
            panel1.ClientRectangle,
            Color.LightSkyBlue,
            Color.White,
            90F))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void lblGreet_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequest();
        }
    }
}
