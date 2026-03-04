using Counseling_Schedule_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Counseling_Schedule_System.Forms
{
    public partial class StudentDashboard : Form
    {
        private int _userID;
        public StudentDashboard(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime finalDateTime = DatePicker.Value.Date + TimePicker.Value.TimeOfDay;

            string connectionString = @"Data Source=DESKTOP-IRCI6E2\SQLEXPRESS;Initial Catalog=CounselingScheduleSystem;Integrated Security=True;Encrypt=False;";
            string sql = @"INSERT INTO requestTbl (StudentID, PreferredDateTime, Reason)
                   VALUES (@StudentID, @PreferredDateTime, @Reason)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = _userID;
                        cmd.Parameters.Add("@PreferredDateTime", SqlDbType.DateTime2).Value = finalDateTime;
                        cmd.Parameters.Add("@Reason", SqlDbType.NVarChar, 500).Value = richTxtReason.Text; 

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Request submitted!");
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
    }
}
