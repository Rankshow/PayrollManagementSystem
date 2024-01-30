namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class EmployeeUpdateRsp<T> : BaseResponse
    {
        public T? Result { get; set; }
    }
}
