using Online_Book_Shopping_System.Entity.Books;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Online_Book_Shopping_System.Repositary
{
    public class BookRepositary
    {
        static string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString; // Get Connection String From App.Config

        SqlConnection dbConnection = new SqlConnection(connection);

        public int addBook(Book book)
        {
            int rows;
            try
            {
                dbConnection.Open();
                string command = "spInsertBook"; // Using Parameterized Command

                using (SqlCommand insertcommand = new SqlCommand(command, dbConnection))
                {
                    insertcommand.CommandType = CommandType.StoredProcedure;
                    // Add The Parameters
                    insertcommand.Parameters.AddWithValue("@Title", book.Title);
                    insertcommand.Parameters.AddWithValue("@Author", book.Author);
                    insertcommand.Parameters.AddWithValue("@Genere", book.Genere);
                    insertcommand.Parameters.AddWithValue("@Price", book.Price);
                    insertcommand.Parameters.AddWithValue("@NoOfPages", book.NoOfPages);



                    SqlDataAdapter sqldataAdapter = new SqlDataAdapter();

                    sqldataAdapter.InsertCommand = insertcommand;
                    rows = insertcommand.ExecuteNonQuery();  // Execute the Insert Query

                }
                addbBookIntoList();
                return rows;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occur : " + e.Message);
                return 0;
            }

            finally
            {
                dbConnection.Close();
            }
        }

        public void addbBookIntoList()
        {

        }
    }
}