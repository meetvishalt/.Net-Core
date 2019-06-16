using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebAPI.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department = "HR", Email = "mary@citiustech.com"},
                new Employee() {Id = 2, Name = "Viajy", Department = "HMT", Email = "vijay@citiustech.com"},
                new Employee() {Id = 3, Name = "Prerana", Department = "IT", Email = "prerana@citiustech.com"}
            };
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public void AddEmployee(Employee emp)
        {
            _employeeList.Add(emp);
        }


    }
}
