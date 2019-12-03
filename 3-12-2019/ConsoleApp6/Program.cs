using System;

using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp6
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
    private static List<Employee> employee = new List<Employee>();

    public static string Designation { get; private set; }
    public static string Department { get; private set; }

        public static void Main(string[] args)
    {
        CompanyEmployees();
        Casting();
        ReadingFile();
        CreateEmployeeList(employee);
        CmpEmployees.DisplayList(employee);
    }
    static void DisplayList(List<Employee> employee)
    {
        foreach (var item in employee)
        {
            Console.WriteLine(item.empId + "," + item.empName + "," + item.Designation + "," + item.Department + "," + item.compId + "," + item.compName);
        }


    }


    public static void CreateEmployeeList(List<Employee> employee)
    {
        string filepath = @"E:\\Users\\Pavan\\File.csv";
        string file1 = @"File1.csv";
        string file2 = @"File2.csv";
        string file3 = @"File3.csv";
        string file4 = @"File4.csv";
        string file5 = @"File5.csv";

        try
        {
                using (StreamWriter sr = new StreamWriter(filepath, true))
                {
                    sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                    foreach (var emp in employee)
                    {
                        
                            Console.WriteLine(emp.empId + "," + emp.empName + "," + emp.Designation + "," + emp.Department + "," + emp.compId + "," + emp.compName);
                        
                    }
                };

                using (StreamWriter sr = new StreamWriter(file1, true))
            {
                sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                foreach (var emp in employee)
                {
                    if (emp.compName == "Dell")
                    {
                        sr.WriteLine(emp.empId + "," + emp.empName + "," + emp.Designation + "," + emp.Department + "," + emp.compId + "," + emp.compName);
                    }
                }
            };
            using (StreamWriter sr = new StreamWriter(file2, true))
            {
                sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                foreach (var emp in employee)
                {
                    if (emp.compName == "SAMSUNG")
                    {
                        sr.WriteLine(emp.empId + "," + emp.empName + "," + emp.Designation + "," + emp.Department + "," + emp.compId + "," + emp.compName);

                    }
                }
            };
            using (StreamWriter sr = new StreamWriter(file3, true))
            {
                sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                foreach (var emp in employee)
                {
                    if (emp.compName == "Asus")
                    {
                        sr.WriteLine(emp.empId + "," + emp.empName + "," + emp.Designation + "," + emp.Department + "," + emp.compId + "," + emp.compName);

                    }
                }
            };
            using (StreamWriter sr = new StreamWriter(file4, true))
            {
                sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                foreach (var emp in employee)
                {
                    if (emp.compName == "Toshiba")
                    {
                        sr.WriteLine(emp.empId + "," + emp.empName + "," + emp.Designation + "," + emp.Department + "," + emp.compId + "," + emp.compName);

                    }
                }
            };

            using (StreamWriter sr = new StreamWriter(file5, true))
            {
                sr.WriteLine("Employeeid" + "," + "EmployeeName" + "," + "Designation" + "," + "Department" + "," + "CompanyId" + "," + "CompanyName");
                foreach (var emp in employee)
                {
                    if (emp.compName == "BizRunTime")
                    {
                        sr.WriteLine(emp.empId + "," + emp.empName + "," + emp.Designation + "," + emp.Department + "," + emp.compId + "," + emp.compName);

                    }
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
"Hethu",
"Hiti",
"Meenakshi",
"Janaki",
"priyanka",
"Kethu"
};
        int[] compid = { 35, 45, 55, 65, 75 };
        string[] compName = { "Dell", "SAMSUNG", "Asus", "Toshiba", "BizRuntime" };
        StringBuilder csvcontent = new StringBuilder();
        csvcontent.AppendLine("EmpId,EmpName,Designation ,DepartMent,CompanyId,CompanyName");
        int empId = 43257;
        for (int j = 1; j <= 5; j++)
        {

            for (int i = 1; i < 200; i++)
            {
                var empObj = new Employee();
                if (i % 5 == 0)
                {
                    csvcontent.AppendLine(++empId + "," + empName[0] + "," + Designation1.NetworkEngineer + "," + Department1.HR + "," + compid[0] + "," + compName[0]);
                    empObj.empName = empName[0];
                    empObj.Designation = Designation1.NetworkEngineer.ToString();
                    empObj.Department = Department1.HR.ToString();
                    empObj.compId = compid[0];
                    empObj.CompName = compName[0];
                }
                else if (i % 4 == 0)
                {
                    csvcontent.AppendLine(++empId + "," + empName[1] + "," + Designation1.SoftwareEngineer + "," + Department1.SalesAndMarketing + " ," + compid[1] + "," + compName[1]);
                        empObj.empName = empName[1];
                        empObj.Designation = Designation1.NetworkEngineer.ToString();
                        empObj.Department = Department1.HR.ToString();
                        empObj.compId = compid[1];
                        empObj.CompName = compName[1];

                    }
                else if (i % 3 == 0)
                {
                    csvcontent.AppendLine(++empId + "," + empName[2] + "," + Designation1.BusinessAnalyst + "," + Department1.Infrastructures + "," + compid[2] + "," + compName[2]);
                        empObj.empName = empName[2];
                        empObj.Designation = Designation1.NetworkEngineer.ToString();
                        empObj.Department = Department1.HR.ToString();
                        empObj.compId = compid[2];
                        empObj.CompName = compName[2];
                    }
                else if (i % 2 == 0)
                {
                    csvcontent.AppendLine(++empId + "," + empName[3] + "," + Designation1.BusinessAnalyst + "," + Department1.Infrastructures + "," + compid[3] + "," + compName[3]);
                        empObj.empName = empName[3];
                        empObj.Designation = Designation1.NetworkEngineer.ToString();
                        empObj.Department = Department1.HR.ToString();
                        empObj.compId = compid[3];
                        empObj.CompName = compName[3];
                    }

                else
                {
                    csvcontent.AppendLine(++empId + "," + empName[4] + "," + Designation1.TechnicalSupport + "," + Department1.IT + "," + compid[4] + "," + compName[4]);
                        empObj.empName = empName[4];
                        empObj.Designation = Designation1.NetworkEngineer.ToString();
                        empObj.Department = Department1.HR.ToString();
                        empObj.compId = compid[4];
                        empObj.CompName = compName[4];
                    }
                empObj.empId = empId;
                employee.Add(empObj);
            }

        }
        string csvPath = @"E:\\Users\\Pavan\\File.csv";
        File.WriteAllText(csvPath, csvcontent.ToString());


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
            Console.WriteLine("Something went wrong..please check your file..");
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Casting()
    {
        Employee emp = new Employee();
        List<Employee> employee = new List<Employee>();
            string[] lines = File.ReadAllLines("E:\\Users\\Pavan\\File.csv");

        foreach (string item in lines)
        {
            var values = item.Split(','); //here we have to split the item.
            Employee e1 = new Employee();
            if (item.IndexOf("EmpId,EmpName") == -1)
            {
                e1.empId = int.Parse(values[0]); //convert into integer
                e1.empName = Convert.ToString(values[1]);
                e1.Designation = Convert.ToString(values[2]);
                e1.Department = Convert.ToString(values[3]);
                e1.compId = int.Parse(values[4]);
                e1.compName = Convert.ToString(values[5]);
                employee.Add(e1);
            }
        }
        foreach (var show in employee)
        {
            Console.WriteLine(show.empId + "," + show.empName + "," + show.Designation + "," + show.Department + "," + show.compId + "," + show.compName);
        }
    }
}
}






