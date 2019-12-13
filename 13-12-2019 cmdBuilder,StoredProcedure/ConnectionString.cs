using System;
using System.Data.SqlClient;

namespace Connection1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                string connectionString = @"Data source = DESKTOP-1KPSOG9\SQLEXPRESS;Initial Catalog = master;Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                try
                {
                    Console.WriteLine("Connection");
                    string query = "SELECT * FROM Person";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(" Fname:{0}\tLname:{1}", reader.GetSqlString(0), reader.GetSqlString(1));
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                        Console.ReadKey();
                    }
                }
            }
        }
    }


