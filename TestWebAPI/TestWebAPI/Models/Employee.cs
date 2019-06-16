using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MinLength(5)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

    }
}
