using System;
using System.Data;

namespace Dtable
{
    class Program
    { 
    private static void Main(string[] args)
    {
        // Here we create the DataTable
        DataTable dt = new DataTable("MyTable");

        // Create the 1st column
        DataColumn column1 = dt.Columns.Add();
        column1.ColumnName = "First";
        column1.DataType = typeof(int);
        column1.DefaultValue = 0;
        column1.Unique = true;
        column1.AllowDBNull = false;

        // Create the 2nd column
        DataColumn column2 = new DataColumn();
        column2.ColumnName = "Second";
        column2.DataType = typeof(string);
        column2.MaxLength = 25;
        dt.Columns.Add(column2);

        // Add the 3rd column instantly
        dt.Columns.Add("Third", typeof(string)).MaxLength = 40;

        // Create the 4th and 5th collumn  and add them together
        DataColumn column4 = new DataColumn("Fourth");
        column4.DataType = typeof(int);
        DataColumn column5 = new DataColumn("Firth", typeof(decimal));
        dt.Columns.AddRange(new DataColumn[] { column4, column5 });

        // Display the Columns in our DataTable
        Console.WriteLine("DataTable {0} has {1} columns: ",
            dt.TableName, dt.Columns.Count);
        Console.WriteLine();
        foreach (DataColumn col in dt.Columns)
        {
            Console.WriteLine("\t\t\t{0}", col.ColumnName);
        }

        Console.ReadKey();
    }
}
}
