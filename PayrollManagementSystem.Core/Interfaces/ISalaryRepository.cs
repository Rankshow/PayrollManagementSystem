using PayrollManagementSystem.Core.Entities;

namespace PayrollManagementSystem.Core.Interfaces
{
    public interface ISalaryRepository
    {
        Task<Salary> Create(Salary Salary);
        Task<Salary> Update(Salary Salary);
        Task<bool> Delete(Guid SalaryId);
        Task<List<Salary>> GetAll();
        Task<Salary> GetById(Guid id);
    }
}
