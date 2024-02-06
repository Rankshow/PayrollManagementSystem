using System.ComponentModel.DataAnnotations;

namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class EmployeeDto
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.   Empty;
        public string PhoneNumber { get; set; } = string.Empty; 
        public int Age { get; set; }
    }
}
