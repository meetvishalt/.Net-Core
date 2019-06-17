using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        IEnumerable<Employee> GetAllEmployees();

        void AddEmployee(Employee emp);

        void UpdateEmployee(Employee emp);

        void DeleteEmployee(int id);
    }
}
