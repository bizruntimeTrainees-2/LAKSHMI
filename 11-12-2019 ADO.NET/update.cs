using System;
using System.Data.SqlClient;

namespace ADO5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = @"Data Source =DESKTOP-1KPSOG9\SQLEXPRESS;Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "update STUDENT set BANGLA = 14 where ID = 4";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {

            }
    
        
        }
    }
}
