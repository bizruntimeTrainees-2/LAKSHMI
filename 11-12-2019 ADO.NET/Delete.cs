using System;
using System.Data.SqlClient;

namespace AD06
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = DESKTOP-1KPSOG9\SQLEXPRESS;Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "DELETE FROM STUDENT WHERE MATH = 5";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
