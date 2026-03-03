using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Forms
{
    public partial class StudentDashboard : Form
    {
        private int _userID;
        public StudentDashboard(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The current user ID is {_userID}");
        }
    }
}
