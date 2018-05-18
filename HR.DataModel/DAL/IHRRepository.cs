using System;
using System.Collections.Generic;
using HR.DataModel.Entities;

namespace HR.DataModel.DAL
{
    public interface IHRRepository
    {
        IEnumerable<Department> GetAllDepartments();
        Department GetDepartment(int departmentId);

        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int employeeId);

        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);

        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
