using System;
using System.Data.SqlClient;

namespace ADO4
{
    class Program
    {

        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-1KPSOG9\\SQLEXPRESS;Integrated Security = SSPI");
            con.Open();
            string USERNAME, PASSWORD;
            Console.WriteLine("Enter username and password");
            USERNAME = Console.ReadLine();
            PASSWORD = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert into Tbl.Login values('" + USERNAME + "','" + PASSWORD + "')", con);
           cmd.ExecuteNonQuery();
            
            con.Close();
        }
    }
}
