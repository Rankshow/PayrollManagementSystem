namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class EmployeeRsp<T> : BaseResponse
    {  
        public T? Result { get; set; }  
    }
}
