using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id=1,
                    Name="Vishal",
                    Department = "HMT",
                    Email="Vishal@citiustech.com"
                });
        }
        public DbSet<Employee> Employees { get; set; }
        
    }
}
