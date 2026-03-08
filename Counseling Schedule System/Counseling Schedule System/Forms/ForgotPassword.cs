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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            RoundedCorners(25);
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
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

        private void btnNVM_Click(object sender, EventArgs e)
        {
            StudentLogin Login = new StudentLogin();
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
    }
}
