using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR.DataModel.Entities
{
    [Table("Departments")] // redundant, example only
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Department Name is required")]
        [MaxLength(100, ErrorMessage = "Department Name cannot exceed more the 100 characters")]
        [MinLength(3, ErrorMessage = "Department Name may have at least 3 characters")]
        public string Name { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}

