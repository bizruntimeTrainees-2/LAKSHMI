using System;
using System.Data;
using System.Data.SqlClient;

namespace AdaptSelect
{
        class Program
        {
            static void Main(string[] args)
            {
                string connectionString = @"Data Source =DESKTOP-1KPSOG9\SQLEXPRESS;Initial Catalog = master;Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SELECT empName,salary FROM EMPLOYEE",con);
            sda.SelectCommand = cmd;
            
            DataTable table = new DataTable();
            sda.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                Console.WriteLine("empName = " + row[0]);
                Console.WriteLine("salary =" + row[1]);
            }
          

            


        }
        }
    }


