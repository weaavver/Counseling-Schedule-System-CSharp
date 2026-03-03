using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counseling_Schedule_System.UserDAO
{

    public class LoginResult
    {
        public bool Success { get; set; }
        public int CounsellorID { get; set; }

        public LoginResult(bool success, int counsellorID)
        {
            Success = success;
            CounsellorID = counsellorID;
        }
    }

    public class UserDAO
    {
        public static LoginResult CounsellorLogin(string username, string password)
        {
            string connectionString = @"Data Source=DESKTOP-IRCI6E2\SQLEXPRESS;Initial Catalog=CounselingScheduleSystem;Integrated Security=True;Encrypt=False;";
            string sql = "SELECT ID, password FROM studentTbl WHERE username = @username";

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
                                string storedHash = reader["password"].ToString();
                                int counsellorID = Convert.ToInt32(reader["ID"]);

                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    return new LoginResult(true, counsellorID);
                                }
                                else
                                {
                                    return new LoginResult(false, -1);
                                }
                            }
                            else
                            {
                                return new LoginResult(false, -1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new LoginResult(false, -1);
            }
        }

        public static int? UserLogin(string username, string password)
    {
        string connectionString = @"Data Source=DESKTOP-IRCI6E2\SQLEXPRESS;Initial Catalog=CounselingScheduleSystem;Integrated Security=True;Encrypt=False;";
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

    }
}
