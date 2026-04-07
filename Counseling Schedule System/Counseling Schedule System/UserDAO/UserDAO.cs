using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Counseling_Schedule_System.UserDAO
{

    public class LoginResult
    {
        // removed SqlConnection here (not used and causes issues)
        public bool Success { get; set; }
        public int userID { get; set; }

        public LoginResult(bool success, int ID)
        {
            Success = success;
            userID = ID;

            // removed invalid connStr + SqlConnection (not needed here)
        }
    }

    public class UserDAO
    {
        // FIX: declare connection string here so all methods can use it
        private static string connectionString = ConfigurationManager
            .ConnectionStrings["DbConnection"]
            .ConnectionString;


        public static int? CounselorLogin(string username, string password)
        {
            string sql = "SELECT counselorID, password FROM counselorTbl WHERE username = @username";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userID = Convert.ToInt32(reader["counselorID"]);
                                string storedHash = reader["password"].ToString();

                                // Compare the entered password (unhashed) with the stored bcrypt hash
                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    MessageBox.Show("Stored Hash: " + storedHash);
                                    return userID; // login success
                                }
                                else
                                {
                                    return null; // wrong password
                                }
                            }
                            else
                            {
                                return null; // no such user
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
                return null;
            }
        }



        public static int? StudentLogin(string username, string password)
        {
            // FIX: removed hardcoded connection string, now using shared one above
            string sql = "SELECT studentID, password FROM studentTbl WHERE username = @username";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userID = Convert.ToInt32(reader["studentID"]);
                                string storedHash = reader["password"].ToString();

                                // Compare the entered password (unhashed) with the stored bcrypt hash
                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    return userID; // login success
                                }
                                else
                                {
                                    return null; // wrong password
                                }
                            }
                            else
                            {
                                return null; // no such user
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
                return null;
            }
        }

    }
}