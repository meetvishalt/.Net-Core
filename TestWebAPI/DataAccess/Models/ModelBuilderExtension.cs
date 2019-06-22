using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Vishal",
                    Department = "HMT",
                    Email = "Vishal@citiustech.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Vijay",
                    Department = "HR",
                    Email = "Vijay@citiustech.com"
                }

                );
        }
    }
}
