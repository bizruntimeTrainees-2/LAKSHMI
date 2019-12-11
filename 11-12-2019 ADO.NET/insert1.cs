using System;
using System.Data.SqlClient;

namespace ADO7
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = DESKTOP-1KPSOG9\SQLEXPRESS; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "INSERT INTO STUDENT VALUES(5,147,2,5,7)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
