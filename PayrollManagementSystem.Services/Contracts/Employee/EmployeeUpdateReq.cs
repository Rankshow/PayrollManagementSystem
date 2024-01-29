namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class EmployeeUpdateReq : EmployeeCreateReq
    {
        public Guid EmployeeId { get; set; }
    }
}
