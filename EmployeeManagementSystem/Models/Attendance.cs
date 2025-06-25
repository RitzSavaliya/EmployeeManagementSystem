using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee is required.")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [RegularExpression("Present|Absent|Late", ErrorMessage = "Status must be Present, Absent, or Late.")]
        public string Status { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? CheckInTime { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? CheckOutTime { get; set; }

        [StringLength(500, ErrorMessage = "Remarks cannot exceed 500 characters.")]
        public string Remarks { get; set; }
    }
}
