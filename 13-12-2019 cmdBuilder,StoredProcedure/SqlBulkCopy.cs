using System;
using System.Data.SqlClient;

namespace SqlBulkCopy1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Establishing connection
            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder();
            cb.DataSource = @"DESKTOP-1KPSOG9\SQLEXPRESS";
            cb.InitialCatalog = "SAMPLE";
            cb.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(cb.ConnectionString);
            // Getting source data
            SqlCommand cmd = new SqlCommand("SELECT * FROM PersonDetails", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            // Initializing an SqlBulkCopy object
            SqlBulkCopy sbc = new SqlBulkCopy(@"server = DESKTOP-1KPSOG9\SQLEXPRESS;database = master;Integrated Security = True");

            // Copying data to destination
            sbc.DestinationTableName = "PersnalDetails1";
            sbc.WriteToServer(rdr);

            // Closing connection and the others
            sbc.Close();
            rdr.Close();
            con.Close();

        }
    }
}
