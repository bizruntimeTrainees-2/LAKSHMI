using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Employee
    {
        public int Employeeid { get; set; }
        public String EmployeeName { get; set; }
    }
    public class LinqEx1
    {
        public static void Main(string[] args)
        {
            Employee[] employeesArray = {
                new Employee(){ Employeeid= 1, EmployeeName = "lakky"},
                new Employee(){ Employeeid= 2, EmployeeName = "lucky"},
            };
			var selectQuery = (from emp in employeesArray
							   select new Employee()
							   {
								   Employeeid = emp.Employeeid,
							   }).ToList();
           // Employee[] employee = new Employee[10];
            foreach (Employee emp in employeesArray)
            {
                Console.WriteLine(emp.Employeeid + ":"+ emp.EmployeeName);

            }
            Console.ReadLine();
        }
    }
}