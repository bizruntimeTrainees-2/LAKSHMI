using System;
using System.Data;
using System.Data.SqlClient;

namespace storedproc1
{
    class Program
    { 
    static void Main(string[] args)
    {
        string connectionString = @"Data Source=DESKTOP-1KPSOG9\SQLEXPRESS; database=master;Integrated Security=SSPI";
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            Console.WriteLine("I am adding students");
            SqlCommand cmd = new SqlCommand("spAddStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            Console.Write("Enter Student_Name:");
            cmd.Parameters.AddWithValue("@Student_Name", Console.ReadLine());
            Console.Write("Enter  Marks:");
            cmd.Parameters.AddWithValue("@Marks", Console.ReadLine());

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@Student_Id";
            outputParameter.SqlDbType = SqlDbType.Int;
            outputParameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);
            con.Open();
            cmd.ExecuteNonQuery();

            string EmpId = outputParameter.Value.ToString();
            Console.WriteLine("Rows Inserted successfully!");
            Console.WriteLine("Inserted with Id: " + EmpId);
        }
        Console.WriteLine("query added successfully!");
    }
}
}
