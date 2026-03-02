using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Section { get; set; }
        public string StudentNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length >= 8)
                    _password = value;
                else
                    MessageBox.Show("Password must be at least 8 characters!");
            }
        }

        public string ConfirmPassword { get; set; }

        // Validation method that shows MessageBox for each error
        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("Name cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Section))
            {
                MessageBox.Show("Section cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(StudentNo))
            {
                MessageBox.Show("Student Number cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(MobileNo))
            {
                MessageBox.Show("Mobile Number cannot be empty!");
                return false;
            }

            if (!Regex.IsMatch(MobileNo, "^[0-9]*$"))
            {
                MessageBox.Show("Mobile Number must contain only digits!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Email cannot be empty!");
                return false;
            }

            if (!Regex.IsMatch(Email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Email format is invalid!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Username))
            {
                MessageBox.Show("Username cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Password cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                MessageBox.Show("Confirm Password cannot be empty!");
                return false;
            }

            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match!");
                return false;
            }

            // All checks passed
            return true;
        }
    } 
}
