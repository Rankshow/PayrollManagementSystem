using PayrollManagementSystem.Core.Entities;

namespace PayrollManagementSystem.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> Create(Employee employee);
        Task<Employee> Update(Employee employee);
        Task<bool> Delete(Guid employeeId);
        Task<List<Employee>> GetAll();
        Task<Employee?> GetById(Guid employeeId);
    }
}
