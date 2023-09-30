﻿using Microsoft.EntityFrameworkCore;

namespace DBFirstProject.Context
{
    public class EmployeeDbContext : DbContext
    {
       
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Employee> Employees { get; set; }
    }
}
