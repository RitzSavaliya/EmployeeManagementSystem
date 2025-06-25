using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class LeaveType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Leave type name is required.")]
        [StringLength(50, ErrorMessage = "Leave type name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Maximum days are required.")]
        [Range(1, 365, ErrorMessage = "Maximum days must be between 1 and 365.")]
        public int MaxDays { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }
    }
}
