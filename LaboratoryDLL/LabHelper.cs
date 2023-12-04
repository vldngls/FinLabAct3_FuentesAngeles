using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaboratoryDLL
{
    public class LabHelper
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FinLabAct3_FuentesAngeles\FinLabAct3_FuentesAngeles\LaboratoryDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

        public DataTable GetAllUsers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("GetAllUsers", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public Tuple<string, string> AuthenticateUser(string userID, string userPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("AuthenticateUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@UserPassword", userPassword);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userType = reader["UserType"].ToString();
                            string firstName = reader["FirstName"] is DBNull ? null : reader["FirstName"].ToString();

                            return new Tuple<string, string>(userType, firstName);
                        }
                        else
                        {
                            return new Tuple<string, string>("Invalid", null);
                        }
                    }
                }
            }
        }

        public DataTable GetUserInfo(string userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("GetUserInfo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
