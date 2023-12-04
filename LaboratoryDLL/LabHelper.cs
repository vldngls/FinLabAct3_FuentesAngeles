using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaboratoryDLL
{
    public class LabHelper
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FinLabAct3_FuentesAngeles\FinLabAct3_FuentesAngeles\LaboratoryDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";

        public DataTable ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("ValidateUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.Add("@UserExists", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        bool userExists = Convert.ToBoolean(cmd.Parameters["@UserExists"].Value);

                        if (userExists)
                        {
                            return dt; // User exists, password may or may not be correct
                        }
                        else
                        {
                            return null; // User does not exist
                        }
                    }
                }
            }
        }

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
    }
}
