using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR.DataModel.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public FullName FullName { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (FullName != null)
                {
                    return string.Format("{0} {1} {2}",
                        FullName.FirstName,
                        FullName.MiddleName ?? string.Empty,
                        FullName.LastName);
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        [MaxLength(12, ErrorMessage = "PhoneNumber cannot exceed more the 12 characters")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "PhoneNumber should be like 'xxx-xxx-xxxx'")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [MaxLength(50, ErrorMessage = "Email Address cannot exceed more the 50 characters")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "Email is not a valid format")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Range(0, 1000000, ErrorMessage = "Salary may be between 0 an 1M")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Salary { get; set; }

        [Display(Name = "Is Contract")]
        public bool IsContract { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Required(ErrorMessage = "Employee should belong to the Department")]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
