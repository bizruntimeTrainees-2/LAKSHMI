using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ__TO_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Get the Data in JSON Serialized Form
            string StudentsData = JsonConvert.SerializeObject(new StudentsDatabase(), Formatting.Indented);
            //Console.WriteLine(StudentsData);  

            //2. Convert the JSON string into an Array
            JArray studentsArray = JArray.Parse(StudentsData);


            //3. Read all Student Names

            var resStudents = (from s in studentsArray
                               select s["StudentName"]).ToList();

            Console.WriteLine("Only Student Names");
            foreach (var item in resStudents)
            {
                Console.WriteLine(item.Value<string>().ToString());
            }

            //4. Get only Course Details 
            Console.WriteLine();
            var result = (from s in studentsArray.Children()["Courses"]
                          select s).ToList();

            Console.WriteLine("Course Details");
            foreach (var item in result.Children().ToList())
            {
                Console.WriteLine(item.ToObject<Course>().CourseId + "\t" + item.ToObject<Course>().CourseName);
            }


            //5. Get the Data in JSON Serialized Form
            string employeesData = JsonConvert.SerializeObject(new EmployeesDatabase(), Formatting.Indented);

            //6. Convert the JSON string into an Array
            JArray employeesArray = JArray.Parse(employeesData);

            //7.
            var empGroupByDeptName = from e in employeesArray
                                     group e by e["DeptName"] into deptGroup
                                     select new
                                     {
                                         DeptName = deptGroup.Key,
                                         EmpCount = deptGroup.Count()

                                     };

            Console.WriteLine("Deptrtment \t\t Total Employees Employee");
            foreach (dynamic deptGrp in empGroupByDeptName)
            {
                Console.WriteLine(deptGrp.DeptName + " \t\t " + deptGrp.EmpCount);
            }

            Console.ReadLine();
        }
    }
}
