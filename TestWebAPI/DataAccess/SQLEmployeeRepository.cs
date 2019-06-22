using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private AppDbContext _context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var empToDelete = _context.Employees.Find(id);
            if(empToDelete != null)
            {
                _context.Remove(empToDelete);
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                return employee;
            }
            else
                return null;
        }

        public void UpdateEmployee(Employee emp)
        {
            var employee = _context.Employees.Attach(emp);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
