using Counseling_Schedule_System.Forms;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Counseling_Schedule_System
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
            btnCounselorLogin.Size = new Size(30, 25); // Set the size of the button
            btnCounselorLogin.Location = new Point(358, 513); // Set the location of the button
            btnCounselorLogin.BackColor = Color.Transparent; // Make the button invisible
            btnCounselorLogin.FlatAppearance.MouseOverBackColor = Color.Transparent; // Make the button invisible when the mouse is over it
            btnCounselorLogin.FlatAppearance.MouseDownBackColor = Color.Transparent; // Make the button invisible when it's clicked
            btnCounselorLogin.FlatStyle = FlatStyle.Flat; // Required to make the button invisible
            btnCounselorLogin.FlatAppearance.BorderSize = 0; // Required to make the button invisible
            
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void Register()
        {
            StudentRegister register = new StudentRegister();
            register.Opacity = 0;
            register.Show();

            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 20;

            fadeTimer.Tick += (s, ev) =>
            {
                if (register.Opacity < 1)
                    register.Opacity += 0.05;
                else
                {
                    fadeTimer.Stop();
                    this.Hide();
                }
            };

            fadeTimer.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPass.Checked;
        }

        private void btnCounselorLogin_Click(object sender, EventArgs e)
        {
            CounselorLogin Login = new CounselorLogin();
            Login.Opacity = 0;
            Login.Show();

            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 20;

            fadeTimer.Tick += (s, ev) =>
            {
                if (Login.Opacity < 1)
                    Login.Opacity += 0.05;
                else
                {
                    fadeTimer.Stop();
                    this.Hide();
                }
            };

            fadeTimer.Start();
        }
    

        private void Login()
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                int? userID = UserDAO.UserDAO.StudentLogin(username, password);
                if (userID.HasValue)
                {
                    MessageBox.Show("Login successful!");

                    StudentDashboard dashboard = new StudentDashboard(userID.Value);
                    dashboard.Opacity = 0;
                    dashboard.Show();

                    Timer fadeTimer = new Timer();
                    fadeTimer.Interval = 20;

                    fadeTimer.Tick += (s, ev) =>
                    {
                        if (dashboard.Opacity < 1)
                            dashboard.Opacity += 0.05;
                        else
                        {
                            fadeTimer.Stop();
                            this.Hide();
                        }
                    };

                    fadeTimer.Start();
                }
                else
                {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnBacktoLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Do you want to exit the application?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Login();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Register();
        }

        private void forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string choice = FormMessageBoxRetryAndForgotPass.Show(
            "Do you want to retry or reset your password?",
            "Retry",
            "Forgot Password(NOT YET IMPLEMENTED)"
            );

            if (choice == "Retry")
            {
                txtPassword.Clear();
            }
            else if (choice == "Forgot Password(NOT YET IMPLEMENTED)")
            {
                ForgotPassword forgotPasswordForm = new ForgotPassword();
                forgotPasswordForm.Opacity = 0;
                forgotPasswordForm.Show();

                Timer fadeTimer = new Timer();
                fadeTimer.Interval = 20;

                fadeTimer.Tick += (s, ev) =>
                {
                    if (forgotPasswordForm.Opacity < 1)
                        forgotPasswordForm.Opacity += 0.05;
                    else
                    {
                        fadeTimer.Stop();
                        this.Hide();
                    }
                };

                fadeTimer.Start();
            }
        }
    }
}
