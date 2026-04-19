using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Forms
{
    public partial class emailVerification : Form
    {
        private String email;
        private string generatedOTP;
        private DateTime otpTime;
        public emailVerification(string email)
        {
            InitializeComponent();

            lblEmail.Text = email;
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            lblEmail.TextAlign = ContentAlignment.MiddleRight;

            this.email = email;
        }

        private string GenerateOTP()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString(); //6 digit OTP
        }

        private void SendOTPEmail(string toEmail, string otp)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("counselingguidanceoffice@gmail.com");
                msg.To.Add(toEmail);
                msg.Subject = "Your OTP Code";
                msg.Body = $"Your OTP is: {otp}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("counselingguidanceoffice@gmail.com", "epqrpcohttikqgkh");
                smtp.EnableSsl = true;

                smtp.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP:\n" + ex.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void emailVerification_Load(object sender, EventArgs e)
        {
            generatedOTP = GenerateOTP();
            otpTime = DateTime.Now;

            SendOTPEmail(email, generatedOTP);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            // Check expiration (20 mins)
            if (DateTime.Now > otpTime.AddMinutes(20))
            {
                MessageBox.Show("OTP expired");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            if (txtOTP.Text == generatedOTP)
            {
                MessageBox.Show("Email verified!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }
        }
    }
}
