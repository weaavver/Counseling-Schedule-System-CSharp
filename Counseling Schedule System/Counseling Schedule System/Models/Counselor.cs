using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Counseling_Schedule_System.Models
{
    public class Counselor
    {
        public string Name { get; set; }
        public string Gender { get; set; } // "Male" or "Female" or other options
        public string Specialization { get; set; }
        public string PRCLicenseNumber { get; set; }
        public string MobileNumber { get; set; }
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

            if (string.IsNullOrWhiteSpace(Gender))
            {
                MessageBox.Show("Gender must be selected!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Specialization))
            {
                MessageBox.Show("Specialization cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PRCLicenseNumber))
            {
                MessageBox.Show("PRC License Number cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(MobileNumber))
            {
                MessageBox.Show("Mobile Number cannot be empty!");
                return false;
            }

            if (!Regex.IsMatch(MobileNumber, "^[0-9]*$"))
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