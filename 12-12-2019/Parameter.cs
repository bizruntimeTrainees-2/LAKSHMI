using System;
using System.Data.SqlClient;

namespace Ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlDataReader reader = null;
            string inputName = "LAKSHMI";
            try
            {
                con = new SqlConnection(@"Data Source = DESKTOP-1KPSOG9\SQLEXPRESS;Integrated Security = True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ADO WHERE NAME = @NAME", con);
                //parameters defining used in command
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@NAME";  //Proper syntax of a parameter
                param.Value = inputName;
                //add new paarmeter to command object
                cmd.Parameters.Add(param);
                 reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Console.WriteLine("{0},{1}", reader["ID"], reader["NAME"]);
                }
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                if(con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
//it will reads the record list of whose name starts with lakshmi.
// use parameters to filter queries in a secure manner.
