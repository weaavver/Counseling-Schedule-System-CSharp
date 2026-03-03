using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Counseling_Schedule_System.Forms;

namespace Counseling_Schedule_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int? userID = UserDAO.UserDAO.UserLogin(username, password);
            if (userID.HasValue) {
                MessageBox.Show("Login successful!");
                
                StudentDashboard studentDashboard = new StudentDashboard(userID.Value);
                studentDashboard.Show();
                this.Hide();
            }
            else {
                    MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
