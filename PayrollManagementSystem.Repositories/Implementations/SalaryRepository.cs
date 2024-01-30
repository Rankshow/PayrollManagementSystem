using Microsoft.EntityFrameworkCore;
using PayrollManagementSystem.Core.Entities;
using PayrollManagementSystem.Core.Interfaces;
using PayrollManagementSystem.Repositories.Data;

namespace PayrollManagementSystem.Repositories.Implementations
{
    public class SalaryRepository : ISalaryRepository
    {
        private readonly PayrollContext _payrollContext;
        public SalaryRepository(PayrollContext payrollContext)
        {
            _payrollContext = payrollContext;
        }
        public async Task<Salary> Create(Salary Salary)
        {
            _payrollContext.Salaries.Add(Salary);
            _payrollContext.SaveChanges();
            return await Task.FromResult(Salary);
        }

        public async Task<bool> Delete(Guid salaryId)
        {
            var toDelete = await _payrollContext
                .Salaries
                .Where(s => s.SalaryId == salaryId)
                .FirstOrDefaultAsync();

            _payrollContext.Salaries.Remove(toDelete ?? new Salary());
            _payrollContext .SaveChanges();
            return await Task.FromResult(true);
        }

        public async Task<List<Salary>> GetAll()
        {
            return await Task.FromResult(_payrollContext
                .Salaries
                .ToList());
        }

        public async Task<Salary?> GetById(Guid salaryId)
        {
            var getId = await _payrollContext
                .Salaries
                .Where( p => p.SalaryId == salaryId )
                .FirstOrDefaultAsync();  

            _payrollContext.Salaries.Add(getId ?? new Salary());
            _payrollContext.SaveChanges();
            return await Task.FromResult(getId);
        }

        public async Task<Salary> Update(Salary Salary)
        {
            var update = _payrollContext.Salaries.Update(Salary);
            return await Task.FromResult(Salary);
        }
    }
}
