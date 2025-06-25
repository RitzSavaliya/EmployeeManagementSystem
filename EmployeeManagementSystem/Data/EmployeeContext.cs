using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeContext: IdentityDbContext<ApplicationUser>
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set precision and scale for decimal
            modelBuilder.Entity<Employee>()
                        .Property(e => e.Salary)
                        .HasPrecision(18, 2); // 18 digits total, 2 after decimal

            base.OnModelCreating(modelBuilder);
        }
    }
}
