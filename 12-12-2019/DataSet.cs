using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO10
{
    
        class Program
        {
            static void Main()
            {
               
                    // This is my connection string - make sure you change it 
                    // respectively if is needed
                    string sqlConn = @"Data Source=DESKTOP-1KPSOG9\SQLEXPRESS;Initial Catalog=master; 
                    Integrated security=SSPI";

                    string sqlSelect = "SELECT ID,NAME FROM ADO";

                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, sqlConn);

                    // Create and fill the DataSet
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ADO");

                   Console.WriteLine(ds.GetXml());


                    Console.ReadKey();

                
                

            }
        }
    }

