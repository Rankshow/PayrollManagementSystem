using PayrollManagementSystem.Services.Contracts.Employee;

namespace PayrollManagementSystem.Services.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeRsp<EmployeeDto> Create(EmployeeCreateReq req);
        Task<EmployeeRsp<EmployeeDto>> Update(EmployeeUpdateReq req);
        Task<EmployeeRsp<EmployeeDto>> GetById(Guid employeeId);
        Task<EmployeeRsp<bool>> Delete(Guid employeeId);
        Task<EmployeeRsp<List<EmployeeDto>>> GetAll();
    }
}
