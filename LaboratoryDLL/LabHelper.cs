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

        public void InsertUser(string userID, string firstName, string lastName, string gender, string course, string userPassword, string userType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("InsertUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Course", course);
                    command.Parameters.AddWithValue("@UserPassword", userPassword);
                    command.Parameters.AddWithValue("@UserType", userType);

                    connection.Open();
                    command.ExecuteNonQuery();
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

        public DataTable GetMatchingUserNames(string searchKeyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("GetMatchingUserNames", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SearchKeyword", searchKeyword);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        public void ChangeUserPassword(string userID, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("ChangeUserPassword", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.Add("@UserID", SqlDbType.NVarChar, 50).Value = userID;
                    cmd.Parameters.Add("@NewPassword", SqlDbType.NVarChar, 50).Value = newPassword;

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
