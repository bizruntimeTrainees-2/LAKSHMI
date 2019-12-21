using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace views.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            { new Employee() {Id = 1,Name = "Lakshmi",Department = "IT",Email = "lakky@gmail.com"},
              new Employee() {Id = 2,Name = "priya",Department = "HR",Email = "priya@gmail.com"},
              new Employee() {Id = 3,Name = "sunita",Department = "IT",Email = "suni@gmail.com"},
             };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
