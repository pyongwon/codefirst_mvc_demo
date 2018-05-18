using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.DataModel.Entities;

namespace HR.DataModel.DAL
{
    public class EFHRRepository : IHRRepository
    {
        public IEnumerable<Department> GetAllDepartments()
        {
            IEnumerable<Department> departments;
            using (var context = new HumanResourceContext())
            {
                departments = context.Departments.ToList();
            }
            return departments;
        }

        public Department GetDepartment(int departmentId)
        {
            Department department;
            using (var context = new HumanResourceContext())
            {
                department = context.Departments.Find(departmentId);
            }
            return department;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            IEnumerable<Employee> employees;
            using (var context = new HumanResourceContext())
            {
                employees = context.Employees.ToList();
            }
            return employees;
        }

        public Employee GetEmployee(int employeeId)
        {
            Employee employee;
            using (var context = new HumanResourceContext())
            {
                employee = context.Employees.Find(employeeId);
            }
            return employee;
        }

        public void AddDepartment(Department department)
        {
            using (var context = new HumanResourceContext())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public void UpdateDepartment(Department department)
        {
            using (var context = new HumanResourceContext())
            {
                context.Entry<Department>(department).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteDepartment(Department department)
        {
            using (var context = new HumanResourceContext())
            {
                context.Entry<Department>(department).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void AddEmployee(Employee employee)
        {
            using (var context = new HumanResourceContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (var context = new HumanResourceContext())
            {
                context.Entry<Employee>(employee).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            using (var context = new HumanResourceContext())
            {
                context.Entry<Employee>(employee).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
