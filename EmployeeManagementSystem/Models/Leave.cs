using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Leave
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee is required.")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required(ErrorMessage = "Leave type is required.")]
        public int LeaveTypeId { get; set; }

        public LeaveType LeaveType { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [RegularExpression("Pending|Approved|Rejected", ErrorMessage = "Status must be Pending, Approved, or Rejected.")]
        public string Status { get; set; }

        [StringLength(500, ErrorMessage = "Reason cannot exceed 500 characters.")]
        public string Reason { get; set; }

        public DateTime AppliedDate { get; set; }
    }
}
