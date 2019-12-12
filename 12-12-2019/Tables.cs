using System;
using System.Data;

namespace DataSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet("Create dataSet"); //here i created dataset
            DataTable dt = new DataTable("Table1"); //adding tables here
            ds.Tables.Add(dt);
            DataTable dt1 = new DataTable("Table2");
            ds.Tables.Add(dt1);

            DataTable dt3 = new DataTable("Table-3");
            DataTable dt4 = new DataTable("Table-4");
            // Configure those tables and then add them 
            // together 
            ds.Tables.AddRange(new DataTable[] { dt3, dt4 });
            Console.WriteLine("DataSet {0} has the following {1} DataTables",
               ds.DataSetName, ds.Tables.Count);

            foreach (DataTable table in ds.Tables)
                Console.WriteLine("\t\t\t{0}", table.TableName);

            Console.ReadKey();

        }
    }
}
