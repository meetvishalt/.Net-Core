using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private ILogger<EmployeeController> _logger;
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository, ILogger<EmployeeController> logger)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }
        // GET: api/Employee
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<Employee> Get()
        {
            _logger.LogInformation("Info Employees Get");
            _logger.LogWarning("Warning Employees Get");
            return _employeeRepository.GetAllEmployees();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_employeeRepository.GetEmployee(id).Name);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee value)
        {
            _employeeRepository.AddEmployee(value);

            return CreatedAtAction("Get", new { id = value.Id });
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
