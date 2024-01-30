using PayrollManagementSystem.Services.Contracts.Employee;

namespace PayrollManagementSystem.Services.Contracts.Department
{
    public class DepartmentRsp<T> : BaseResponse
    {
        public T? Result { get; set; }
    }
}
