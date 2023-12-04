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
        public string AuthenticateUser(string userID, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("AuthenticateUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = userID;
                    cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = password;
                    cmd.Parameters.Add("@UserType", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    return cmd.Parameters["@UserType"].Value.ToString();
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
