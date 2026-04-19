using Counseling_Schedule_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Counseling_Schedule_System.Forms
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnNVM_Click(object sender, EventArgs e)
        {
            StudentLogin Login = new StudentLogin();
            Login.Show();
            this.Hide();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text.Trim();
            if (!Regex.IsMatch(Email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Email format is invalid!");
            }
            else
            {
                emailVerification otpForm = new emailVerification(txtEmail.Text);

                if (otpForm.ShowDialog() == DialogResult.OK)
                {
                    studentChangePassword form = new studentChangePassword(txtEmail.Text);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email verification failed.");
                }
            }

        }
    }
}
