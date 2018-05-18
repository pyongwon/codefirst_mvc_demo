using HR.DataModel.Entities;
using System;
using System.Data.Entity;

namespace HR.DataModel.DAL 
{
    public class InitializeHRDbWithSeedData : DropCreateDatabaseIfModelChanges<HumanResourceContext>
    {
        protected override void Seed(HumanResourceContext context)
        {
            Department dep1 = new Department { Id = 1, Name = "Development" };
            Department dep2 = new Department { Id = 2, Name = "Marketing" };
            Department dep3 = new Department { Id = 3, Name = "Sales" };

            FullName homer = new FullName { FirstName = "Homer", MiddleName = "J.", LastName = "Simpson" };
            FullName bart = new FullName { FirstName = "Bart", LastName = "Simpson" };
            FullName lisa = new FullName { FirstName = "Lisa", LastName = "Simpson" };
            FullName marge = new FullName { FirstName = "Marge", LastName = "Simpson" };

            Employee emp1 = new Employee { Id = 1, FullName = homer, EmailAddress = "homer@donut.com", Salary = 1000M, IsContract = false, DepartmentId = 1, Department = dep1 };
            Employee emp2 = new Employee { Id = 1, FullName = bart, EmailAddress = "bart@donut.com", PhoneNumber = "111-222-3333", Salary = 10000M, DepartmentId = 1, IsContract = false, Department = dep1 };
            Employee emp3 = new Employee { Id = 1, FullName = lisa, EmailAddress = "lisa@donut.com", Salary = 50000M, IsContract = false, DepartmentId = 2, Department = dep2 };
            Employee emp4 = new Employee { Id = 1, FullName = marge, EmailAddress = "marge@donut.com", Salary = 30000M, IsContract = true, DepartmentId = 3, Department = dep3 };


            context.Departments.Add(dep1);
            context.Departments.Add(dep2);
            context.Departments.Add(dep3);

            context.Employees.Add(emp1);
            context.Employees.Add(emp2);
            context.Employees.Add(emp3);
            context.Employees.Add(emp4);
        }

    }
}
