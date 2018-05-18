using HR.DataModel.Entities;
using System;
using System.Data.Entity;

namespace HR.DataModel.DAL
{
    public class HumanResourceContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
