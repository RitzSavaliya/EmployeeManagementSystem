using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        [Range(0, 1000000, ErrorMessage = "Salary must be between 0 and 1,000,000.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Hire date is required.")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
