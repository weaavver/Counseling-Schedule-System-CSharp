using Counseling_Schedule_System.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Counseling_Schedule_System
{
    public partial class StudentRegister : Form
    {
        string connectionString = @"Data Source=DESKTOP-IRCI6E2;Initial Catalog=CounselingScheduleSystem;
        Integrated Security=True;Encrypt=False;";
        public StudentRegister()
        {
            InitializeComponent();
            RoundedCorners(25);
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

        private void btnConfirm_Click(object sender, EventArgs e)
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

            Student student = new Student
            {
                Name = txtName.Text,
                Gender = gender,
                Section = txtYearAndSection.Text,
                StudentNo = txtStudentNo.Text,
                MobileNo = txtMobileNo.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPass.Text,
                ConfirmPassword = txtConfirmPass.Text
            };

            // Validate
            if (!student.IsValid())
            {
                MessageBox.Show("Invalid inputs!");
                return;
            }

            // Hash the password before storing
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(student.Password);

            // Database insertion
            string sql = "INSERT INTO studentTbl(StudentName, Gender, Section, StudentNo, MobileNo, Email, Username, Password) " +
                         "VALUES(@Name, @Gender, @Section, @StudentNo, @MobileNo, @Email, @Username, @Password)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@Gender", student.Gender);
                        cmd.Parameters.AddWithValue("@Section", student.Section);
                        cmd.Parameters.AddWithValue("@StudentNo", student.StudentNo);
                        cmd.Parameters.AddWithValue("@MobileNo", student.MobileNo);
                        cmd.Parameters.AddWithValue("@Email", student.Email);
                        cmd.Parameters.AddWithValue("@Username", student.Username);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword); // <-- hashed here

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Stored hash: " + hashedPassword);
                MessageBox.Show("Registration successful!");
                MessageBox.Show("Please Login");

                // Clear form
                txtName.Clear();
                txtYearAndSection.Clear();
                txtStudentNo.Clear();
                txtMobileNo.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtPass.Clear();
                txtConfirmPass.Clear();

                StudentLogin form = new StudentLogin();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StudentLogin form = new StudentLogin();
            form.Opacity = 0;
            form.Show();

            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 20;

            fadeTimer.Tick += (s, ev) =>
            {
                if (form.Opacity < 1)
                    form.Opacity += 0.05;
                else
                {
                    fadeTimer.Stop();
                    this.Hide();
                }
            };

            fadeTimer.Start();
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
    }
}
