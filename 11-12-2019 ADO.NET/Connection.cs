using System;
using System.Data.SqlClient;

namespace ADO2
{
    class SqlConnectionDemo
    {
        static void Main()
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-1KPSOG9\\SQLEXPRESS;Integrated Security=SSPI");

            SqlDataReader rdr = null;

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command
                SqlCommand cmd = new SqlCommand("select * from ADO", conn);

                //
                // 4. Use the connection
                //
;
                // get query results
                rdr = cmd.ExecuteReader();

                // print the Name of each record
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[1]);

                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}