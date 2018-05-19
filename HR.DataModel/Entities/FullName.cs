using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR.DataModel.Entities
{
    public class FullName
    {
        [Required(ErrorMessage = "First Name is required")]
        [MaxLength(50, ErrorMessage = "First Name cannot exceed more the 50 characters")]
        [MinLength(1, ErrorMessage = "First Name may have at least 1 character")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "Middle Name cannot exceed more the 50 characters")]
        [Column("MiddleName")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(50, ErrorMessage = "Last Name cannot exceed more the 50 characters")]
        [MinLength(1, ErrorMessage = "Last Name may have at least 1 character")]
        [Column("LastName")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}

