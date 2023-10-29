using System.ComponentModel.DataAnnotations;

namespace WebEFAPI_2.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name length should not be greater than 20")]
        public string Emp_Name { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Age should be >= 0 and <= 100")]
        public int Emp_Age { get; set; }
        public string Emp_City { get; set; }
    }
}
