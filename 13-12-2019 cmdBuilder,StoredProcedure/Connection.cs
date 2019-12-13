using System;
using System.Data.SqlClient;

namespace Connection
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
                string query = "SELECT * FROM PersonDetails";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("ID[0] \tNAME[1]\tAGE[2]",reader.GetSqlString(0),reader.GetSqlString(1),reader.GetSqlString(2));
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    Console.ReadKey();
                }
            }
        }
    }
}
