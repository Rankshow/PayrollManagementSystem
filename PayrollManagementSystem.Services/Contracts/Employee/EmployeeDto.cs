using System.ComponentModel.DataAnnotations;

namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class EmployeeDto
    {
        [Required]
        public Guid EmployeeId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Gender { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public double PhoneNumber { get; set; }
        [Required]
        public float Age { get; set; }
    }
}
