namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class EmployeeCreateReq
    {
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public double PhoneNumber { get; set; }
        public float Age { get; set; }
    }
}
