

using System;

using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace TestEmployee.cs
{
 
        public enum Designation1
    {

        WebDeveloper,
        NetworkEngineer,
        SoftwareEngineer,
        BusinessAnalyst,
        SystemsAnalyst,
        TechnicalSupport
    }


    public enum Department1

    {
        AccountsAndFinance,
        HR,
        SalesAndMarketing,
        Infrastructures,
        ResearchAndDevelopment,
        IT
    }

    public class Employee1
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int empId { get; set; }
        public string empName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }

    }
    class Class1
    {
        static void Main(string[] args)
        {
            CompanyEmployees();
        }
        public static void CompanyEmployees()
        {

            Employee emp = new Employee();
            string[] empName = { "Nandini",
                                  "Lavanya",
                                  "Manisha",
                                  "Deeksha",
                                  "Ram mohan Reddy",
                                   "Hethan",
                                    "Hiti"};
            int[] compid = { 35, 45, 55, 65, 75 };
            string[] compName = { "Dell", "SAMSUNG", "Asus", "Toshiba", "Microsoft" };
            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine("EmpId,EmpName,Designation ,DepartMent,CompanyId,CompanyName");
            int empId = 43257;
            for (int j = 1; j <= 5; j++)
            {
               
                for (int i = 1; i < 200; i++)
                {
                    if (i % 6 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[0] + "," + Designation.WebDeveloper + "," + Department.AccountsAndFinance + "," + emp.CompanyId + "," + emp.CompanyName);
                    }
                    else if (i % 5 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[1] + "," + Designation.NetworkEngineer + "," + Department.HR + "," + emp.CompanyId + "," + emp.CompanyName);
                    }
                    else if (i % 4 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[2] + "," + Designation.SoftwareEngineer + "," + Department.SalesAndMarketing + " ," + emp.CompanyId + "," + emp.CompanyName);
                    }
                    else if (i % 3 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[3] + "," + Designation.BusinessAnalyst + "," + Department.Infrastructures + "," + emp.CompanyId + "," + emp.CompanyName);
                    }
                    else if (i % 2 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[4] + "," + Designation.SystemsAnalyst + "," + Department.ResearchAndDevelopment + "," + emp.CompanyId + "," + emp.CompanyName);
                    }
                    else
                    {
                        csvcontent.AppendLine(++empId + "," + empName[5] + "," + Designation.TechnicalSupport + "," + Department.IT + "," + emp.CompanyId + "," + emp.CompanyName);
                    }
                }

            }
            string csvPath = @"E:\\Users\\Pavan\\File.csv";
            File.AppendAllText(csvPath, csvcontent.ToString());

        }
        public static void ReadingFile()
        {
            try
            {
                string file = File.ReadAllText("E:\\Users\\Pavan\\File.csv");
                Console.WriteLine(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something happened wrong!! please check  your file..");
                Console.WriteLine(ex.ToString());
            }
        }

    }
}






