using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Forms
{
    public partial class CounselorLogin : Form
    {

        public CounselorLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CounselorSignup Signup = new CounselorSignup();
            Signup.Opacity = 0;
            Signup.Show();

            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 20;

            fadeTimer.Tick += (s, ev) =>
            {
                if (Signup.Opacity < 1)
                    Signup.Opacity += 0.05;
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int? userID = UserDAO.UserDAO.CounselorLogin(username, password);
            if (userID.HasValue)
            {
                MessageBox.Show("Login successful!");

                CounselorDashboard dashboard = new CounselorDashboard(userID.Value);
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

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPass.Checked;
        }
    }
}
