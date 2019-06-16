using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebAPI.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        List<Employee> GetAllEmployees();

        void AddEmployee(Employee emp);
    }
}
