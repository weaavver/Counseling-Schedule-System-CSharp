using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Forms
{
    public partial class counselorChangePassword : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        private string email;
        public counselorChangePassword(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void ChangePasswordByEmail()
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in both password fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if(newPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            //Hash new password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

            //Update query using Email
            string sql = "UPDATE counselorTbl SET Password = @Password WHERE Email = @Email";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction sqltrn = conn.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, conn, sqltrn))
                        {
                            cmd.Parameters.AddWithValue("@Password", hashedPassword);
                            cmd.Parameters.AddWithValue("@Email", email.Trim());

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                throw new Exception("Email not found in the system.");
                            }
                        }

                        sqltrn.Commit();
                    }
                }

                MessageBox.Show("Password changed successfully! Please log in with your new password.");

                txtNewPassword.Clear();
                txtConfirmPassword.Clear();

                StudentLogin form = new StudentLogin();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            ChangePasswordByEmail();
        }
    }
}
