using System;
using System.Data.SqlClient;


namespace Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = null;
            SqlConnection con;
            SqlCommand cmd;
            SqlTransaction transaction;
            connectionString = @"Data Source = DESKTOP-1KPSOG9\SQLEXPRESS;Initial catalog = master; Integrated Security = True";
            con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                transaction = con.BeginTransaction();//starting connection
                cmd = new SqlCommand("Your Sql statement here", con, transaction);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("your Sql statement here", con, transaction);
                cmd.ExecuteNonQuery();
                transaction.Commit(); //Ending connection

            }
            catch(Exception ex)
            {
                Console.WriteLine("cannot open connection");
            }
            con.Close();
        }
    }
}
