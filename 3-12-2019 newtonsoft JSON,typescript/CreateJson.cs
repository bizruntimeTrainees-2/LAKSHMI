

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

    public class Employee
    {
        internal string compName;

        public int compId { get; set; }
        public string CompName { get; set; }
        public int empId { get; set; }
        public string empName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }

    }
    class CmpEmployees
    {
        private static List<Employee> emp;
        private static string compName;
        private static string empId;
        private static string empName;
        private static string compId;

        public static string Designation { get; private set; }
        public static string Department { get; private set; }

        static void Main(string[] args)
        {
            CompanyEmployees();
            Casting();
            CreateEmployeeList(emp);
            CmpEmployees.DisplayList(emp);
        }
        static void DisplayList(List<Employee> emp)
        {
            foreach (var item in emp)
            {
                Console.WriteLine(item.empId + "," + item.empName + "," + item.Designation + "," + item.Department + "," + item.compId + "," + item.compName);
            }


        }


        public static void CreateEmployeeList(List<Employee> emp)
        {
            string filepath = @"E:\\Users\\Pavan\\File.csv";
            string file1 = @"E:\\Users\\Pavan\\File1.csv";
            string file2 = @"E:\\Users\\Pavan\\File2.csv";
            string file3 = @"E:\\Users\\Pavan\\File3.csv";
            string file4 = @"E:\\Users\\Pavan\\File4.csv";
            string file5 = @"E:\\Users\\Pavan\\File5.csv";
            string file6 = @"E:\\Users\\Pavan\\File6.csv";
            try
            {
                using (StreamWriter sr = new StreamWriter(filepath, true))
                {
                    sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                    foreach (var item in emp)
                    {
                        sr.WriteLine(item.empId + "," + item.empName + "," + item.Designation + "," + item.Department + "," + item.compId + "," + item.compName);
                        Console.WriteLine(item.empId + "," + item.empName + "," + item.Designation + "," + item.compId + "," + item.compName);
                    }
                };
                using (StreamWriter sr = new StreamWriter(file1, true))
                {
                    sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                    if (compName == "Dell")
                    {
                        sr.WriteLine(empId + "," + empName + "," + Designation + "," + Department + "," + compId + "," + compName);
                    }
                };
                using (StreamWriter sr = new StreamWriter(file2, true))
                {
                    sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                    if (compName == "SAMSUNG")
                    {
                        sr.WriteLine(empId + "," + empName + "," + Designation + "," + Department + "," + compId + "," + compName);

                    }
                };
                using (StreamWriter sr = new StreamWriter(file3, true))
                {
                    sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                    if (compName == "Asus")
                    {
                        sr.WriteLine(empId + "," + empName + "," + Designation + "," + Department + "," + compId + "," + compName);

                    }
                };
                using (StreamWriter sr = new StreamWriter(file4, true))
                {
                    sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                    if (compName == "Toshiba")
                    {
                        sr.WriteLine(empId + "," + empName + "," + Designation + "," + Department + "," + compId + "," + compName);

                    }
                };
                using (StreamWriter sr = new StreamWriter(file5, true))
                {
                    sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                    if (compName == "Microsoft")
                    {
                        sr.WriteLine(empId + "," + empName + "," + Designation + "," + Department + "," + compId + "," + compName);

                    }
                };
                using (StreamWriter sr = new StreamWriter(file6, true))
                {
                    sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                    if (compName == "BizRunTime")
                    {
                        sr.WriteLine(empId + "," + empName + "," + Designation + "," + Department + "," + compId + "," + compName);

                    }
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void CompanyEmployees()
        {

            List<Employee> emp = new List<Employee>();
            string[] empName = { "Nandini",
                                  "Lavanya",
                                  "Manisha",
                                  "Deeksha",
                                  "Ram mohan Reddy",
                                  "Hethu"
                                  };
            int[] compid = { 35, 45, 55, 65, 75, 83 };
            string[] compName = { "Dell", "SAMSUNG", "Asus", "Toshiba", "Microsoft", "BizRuntime" };
            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine("EmpId,EmpName,Designation ,DepartMent,CompanyId,CompanyName");
            int empId = 43257;
            for (int j = 1; j <= 5; j++)
            {

                for (int i = 1; i < 200; i++)
                {
                    if (i % 6 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[0] + "," + Designation1.WebDeveloper + "," + Department1.AccountsAndFinance + "," + compid[0] + "," + compName[0]);
                    }
                    else if (i % 5 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[1] + "," + Designation1.NetworkEngineer + "," + Department1.HR + "," + compid[1] + "," + compName[1]);
                    }
                    else if (i % 4 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[2] + "," + Designation1.SoftwareEngineer + "," + Department1.SalesAndMarketing + " ," + compid[2] + "," + compName[2]);
                    }
                    else if (i % 3 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[3] + "," + Designation1.BusinessAnalyst + "," + Department1.Infrastructures + "," + compid[3] + "," + compName[3]);
                    }
                    else if (i % 2 == 0)
                    {
                        csvcontent.AppendLine(++empId + "," + empName[3] + "," + Designation1.BusinessAnalyst + "," + Department1.Infrastructures + "," + compid[4] + "," + compName[4]);
                    }

                    else
                    {
                        csvcontent.AppendLine(++empId + "," + empName[5] + "," + Designation1.TechnicalSupport + "," + Department1.IT + "," + compid[5] + "," + compName[5]);
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
        public static void Casting()
        {
            Employee emp = new Employee();
            List<Employee> emp1 = new List<Employee>();
            var lines = File.ReadAllLines("E:\\Users\\Pavan\\File.csv");

            foreach (string item in lines)
            {
                var values = item.Split(',');       //here we have to split the item.
                Employee e1 = new Employee();
                e1.empId = Convert.ToInt32(values[0]);     //convert into integer
                e1.empName = Convert.ToString(values[1]);
                e1.Designation = Convert.ToString(values[2]);
                e1.Department = Convert.ToString(values[3]);
                e1.compId = Convert.ToInt32(values[4]);
                e1.compName = Convert.ToString(values[5]);
                emp1.Add(e1);
            }

            foreach (var show in emp1)
            {
                Console.WriteLine(show.empId + "," + show.empName + "," + show.Designation + "," + show.Department + "," + show.compId + "," + show.compName);
            }

        }

    }


}







