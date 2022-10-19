using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb2_API_Angular.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Personal Identity Number")]
        [Required(ErrorMessage = "This field is required")]
        [MinLength(10, ErrorMessage = "Minimum 10 characters"), MaxLength(12, ErrorMessage = "Maximum 12 characters")]
        public string PersonalNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "This field is required")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Address")]
        [Required(ErrorMessage = "This field is required")]
        public string Address { get; set; }

        public string Gender { get; set; }
        public int Salary { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
