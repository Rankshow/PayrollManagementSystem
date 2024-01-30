using PayrollManagementSystem.Services.Contracts.Department;
using PayrollManagementSystem.Services.Contracts.Employee;

namespace PayrollManagementSystem.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<DepartmentRsp<DepartmentDto>> Create(DepartmentCreateReq req);
        Task<DepartmentRsp<DepartmentDto>> Update(DepartmentCreateReq req);
        Task<DepartmentRsp<DepartmentDto>> GetById(Guid departmentId);
        Task<DepartmentRsp<bool>> Delete(Guid employeeId);
        Task<DepartmentRsp<List<DepartmentDto>>> GetAll();
    }
}
