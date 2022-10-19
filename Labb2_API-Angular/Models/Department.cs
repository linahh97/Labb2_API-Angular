using System.ComponentModel.DataAnnotations;

namespace Labb2_API_Angular.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }
    }
}