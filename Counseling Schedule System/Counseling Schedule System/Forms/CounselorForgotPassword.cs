using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Forms
{
    public partial class CounselorForgotPassword : Form
    {
        public CounselorForgotPassword()
        {
            InitializeComponent();
        }
        private void btnNVM_Click(object sender, EventArgs e)
        {
            CounselorLogin Login = new CounselorLogin();
            Login.Show();
            this.Hide();
        }

        private void btnSendOTP_Click_1(object sender, EventArgs e)
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
                    counselorChangePassword form = new counselorChangePassword(txtEmail.Text);
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
