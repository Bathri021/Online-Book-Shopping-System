using Online_Book_Shopping_System.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Online_Book_Shopping_System.Repositary
{
    public class UserRepositary : User
    {
        static string connection = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString; // Get Connection String From App.Config

        SqlConnection dbConnection = new SqlConnection(connection);

        public int addUser(User user)
        {
            int affectedRow;
            try
            {
                dbConnection.Open();
                string query = "spInsertUser";

                using (SqlCommand insertCommand = new SqlCommand(query,dbConnection))
                {
                    insertCommand.CommandType = CommandType.StoredProcedure;

                    insertCommand.Parameters.AddWithValue("@Name", user.Name);
                    insertCommand.Parameters.AddWithValue("@UserName", user.UserName);
                    insertCommand.Parameters.AddWithValue("@MailID", user.MailId);
                    insertCommand.Parameters.AddWithValue("@Password", user.Password);
                    insertCommand.Parameters.AddWithValue("@Role", user.Role);

                    SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                    sqlAdapter.InsertCommand = insertCommand;
                    affectedRow = insertCommand.ExecuteNonQuery();
                }
                addUserIntoList();
                return affectedRow;
            }
            catch (Exception)
            {
                return 0;
                
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void addUserIntoList()
        {
            string sqlQuery = "Select * From _User";

            using (SqlCommand selectCommand = new SqlCommand(sqlQuery,dbConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = selectCommand;
                DataSet userDataset = new DataSet();
                adapter.Fill(userDataset, "User");
                DataTable userDataTable = userDataset.Tables["User"];
                // Iterate through the Data table to fetch the Row 
                foreach (DataRow row in userDataTable.Rows)
                {
                    User user = new User
                    {
                        Name = row[0].ToString(),
                        UserName = row[1].ToString(),
                        MailId = row[2].ToString(),
                        Password = row[3].ToString(),
                        Role = row[4].ToString(),
                        UserID = int.Parse(row[5].ToString())
                    };
                    userList.Add(user.UserID, user);  // Add into the List
                }
            }
        }
    }
}