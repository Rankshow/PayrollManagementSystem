using PayrollManagementSystem.Services.Contracts.Employee;

namespace PayrollManagementSystem.Services.Contracts.Department
{
    public class DepartUpdateRsp<T> : BaseResponse
    {
        public T? Result { get; set; }
    }
}
