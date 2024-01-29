using PayrollManagementSystem.Core.Entities;

namespace PayrollManagementSystem.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<Department> Create(Department department);
        Task<Department> Update(Department department);
        Task<bool> Delete(Guid departmentId);
        Task<List<Department>> GetAll();
        Task<Department> GetById(Guid departmentId);
    }
}
