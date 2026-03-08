using System;
using System.Drawing;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Forms
{
    public class FormMessageBoxRetryAndForgotPass : Form
    {
        // Stores which button the user clicked
        public string Result { get; private set; } = "";

        // Constructor
        public FormMessageBoxRetryAndForgotPass(string message, string buttonText1, string buttonText2)
        {
            // Form properties
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(300, 140);
            this.Font = new Font("Segoe UI", 9);
            this.Text = "Invalid Input";

            // Label
            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.AutoSize = false;
            lblMessage.Width = 260;
            lblMessage.Height = 40;
            lblMessage.Top = 15;
            lblMessage.Left = 20;
            this.Controls.Add(lblMessage);

            // Button 1
            Button btn1 = new Button();
            btn1.Text = buttonText1;
            btn1.Size = new Size(90, 25);
            btn1.Top = 70;
            btn1.Left = 50;
            btn1.Click += (s, e) => { Result = buttonText1; this.Close(); };
            this.Controls.Add(btn1);

            // Button 2
            Button btn2 = new Button();
            btn2.Text = buttonText2;
            btn2.Size = new Size(110, 25);
            btn2.Top = 70;
            btn2.Left = 150;
            btn2.Click += (s, e) => { Result = buttonText2; this.Close(); };
            this.Controls.Add(btn2);
        }

        // Static helper method like MessageBox.Show
        public static string Show(string message, string buttonText1 = "Retry", string buttonText2 = "Forgot Password")
        {
            using (var box = new FormMessageBoxRetryAndForgotPass(message, buttonText1, buttonText2))
            {
                box.ShowDialog();
                return box.Result;
            }
        }
    }
}