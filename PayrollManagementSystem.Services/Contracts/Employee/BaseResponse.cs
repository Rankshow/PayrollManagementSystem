namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class BaseResponse
    {
        public string Code {  get; set; } = string.Empty;
        public string? Message { get; set; }
    }
}
