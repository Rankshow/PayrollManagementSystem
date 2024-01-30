using PayrollManagementSystem.Core.Entities;

namespace PayrollManagementSystem.Core.Interfaces
{
    public interface IPayrollRepository
    {
        Task<Payroll> GetAll();
        Task<Payroll> Create(Payroll payroll);
        Task<Payroll> Update(Payroll payroll);
        Task<Payroll> GetById(Guid payrollId);
        Task<Payroll> Delete(Guid payrollId);
    }
}
