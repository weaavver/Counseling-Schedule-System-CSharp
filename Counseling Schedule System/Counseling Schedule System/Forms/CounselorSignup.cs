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
using System.Configuration;

namespace Counseling_Schedule_System.Forms
{
    public partial class CounselorSignup : Form
    {
        public CounselorSignup()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Signup();
        }

        

        private void gBoxGender_Enter(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            txtSpecialization.Clear();
            txtPRCLicense.Clear();
            txtMobileNumber.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            txtConfirmPass.Clear();
        }

        private void Signup()
        {
            string gender = "";
            foreach (RadioButton rb in gBoxGender.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    gender = rb.Text;
                    break;
                }
            }
            Counselor counselor = new Counselor
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = gender,
                Specialization = txtSpecialization.Text,
                PRCLicenseNumber = txtPRCLicense.Text,
                MobileNumber = txtMobileNumber.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPass.Text,
                ConfirmPassword = txtConfirmPass.Text
            };
            if (!counselor.IsValid())
            {
                MessageBox.Show("Invalid inputs!");
                return;
            }
            // Hash the password before storing
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(counselor.Password);

            // Database insertion
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            string sql = "INSERT INTO counselorTbl " +
            "(FirstName, LastName, Gender, Specialization, PRCLicenseNumber, MobileNo, Email, Username, [Password]) " +
            "VALUES(@FirstName, @LastName, @Gender, @Specialization, @PRCLicenseNumber, @MobileNumber, @Email, @Username, @Password)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", counselor.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", counselor.LastName);
                        cmd.Parameters.AddWithValue("@Gender", counselor.Gender);
                        cmd.Parameters.AddWithValue("@Specialization", counselor.Specialization);
                        cmd.Parameters.AddWithValue("@PRCLicenseNumber", counselor.PRCLicenseNumber);
                        cmd.Parameters.AddWithValue("@MobileNumber", counselor.MobileNumber);
                        cmd.Parameters.AddWithValue("@Email", counselor.Email);
                        cmd.Parameters.AddWithValue("@Username", counselor.Username);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Stored hash: " + hashedPassword);
                MessageBox.Show("Registration successful!");
                MessageBox.Show("Please Login");

                // Clear form
                txtLastName.Clear();
                foreach (RadioButton rb in gBoxGender.Controls.OfType<RadioButton>())
                {
                    rb.Checked = false;
                }
                txtSpecialization.Clear();
                txtPRCLicense.Clear();
                txtMobileNumber.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtPass.Clear();
                txtConfirmPass.Clear();

                CounselorLogin login = new CounselorLogin();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPRCLicense_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CounselorLogin form = new CounselorLogin();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpecialization_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
