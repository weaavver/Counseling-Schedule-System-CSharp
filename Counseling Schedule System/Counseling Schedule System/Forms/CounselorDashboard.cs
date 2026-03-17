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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnScheduleRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter
                ("SELECT \r\n    r.requestID,\r\n    s.StudentName,\r\n    c.CounselorName,\r\n    s.MobileNo,\r\n    s.Email\r\nFROM requestTbl r\r\nINNER JOIN studentTbl s \r\n    ON r.StudentID = s.studentID\r\nINNER JOIN counselorTbl c \r\n    ON r.CounselorID = c.counselorID\r\nWHERE r.[Status] = 'Scheduled'\r\nAND r.CounselorID = @userID;", sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@userID", _userID);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvSchedules.ReadOnly = true;
                dgvSchedules.DataSource = dtbl;
            }
        }

        private void btnRequestRefresh_Click(object sender, EventArgs e)
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
                             JOIN counselorTbl c ON c.counselorID = @userID
                             WHERE r.Status = 'Pending'
                             AND s.Gender = c.Gender";

                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@userID", _userID);

                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

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
            string requestID = txtRequestID.Text;
            string status = "Scheduled";
            DateTime scheduledDate = DatePicker.Value.Date;
            TimeSpan scheduledTime = TimePicker.Value.TimeOfDay;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter
                ("UPDATE requestTbl " +
                "SET counselorID = @userID, " +
                "ScheduledDate = @scheduledDate, " +
                "ScheduledTime = @scheduledTime, " +
                "[Status] = @status, " +
                "UpdatedAt = GETDATE() " +
                "WHERE requestID = @requestID", sqlCon);
                
                sqlDa.SelectCommand.Parameters.AddWithValue("@userID", _userID);
                sqlDa.SelectCommand.Parameters.AddWithValue("@requestID", requestID);
                sqlDa.SelectCommand.Parameters.AddWithValue("@scheduledDate", scheduledDate);
                sqlDa.SelectCommand.Parameters.AddWithValue("@scheduledTime", scheduledTime);
                sqlDa.SelectCommand.Parameters.AddWithValue("@status", status);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgvSchedules.DataSource = dtbl;
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

        }

        private void lblGreet_Click(object sender, EventArgs e)
        {

        }
    }
}
