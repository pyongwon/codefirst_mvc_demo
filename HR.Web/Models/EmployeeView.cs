using System;
using System.Collections.Generic;
using HR.DataModel.Entities;

namespace HR.Web.Models
{
    public class EmployeeView
    {
        public Employee Employee { get; set; }
        public List<Department> Departments { get; set; }
    }
}