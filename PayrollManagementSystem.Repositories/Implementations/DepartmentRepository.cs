

using Microsoft.EntityFrameworkCore;
using PayrollManagementSystem.Core.Entities;
using PayrollManagementSystem.Core.Interfaces;
using PayrollManagementSystem.Repositories.Data;

namespace PayrollManagementSystem.Repositories.Implementations
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly PayrollContext _payrollContext;
        public DepartmentRepository(PayrollContext payrollContext)
        {
            _payrollContext = payrollContext; 
        }
        public async Task<Department> Create(Department department)
        {
            _payrollContext.Add(department);
            _payrollContext.SaveChanges();
            return await Task.FromResult(department);
        }

        public async Task<bool> Delete(Guid departmentId)
        {
            var toDelete = await _payrollContext
                .Departments
                .Where( d => d.DepartmentId == departmentId).FirstOrDefaultAsync();

            _payrollContext.Departments.Remove(toDelete ?? new Department());
            _payrollContext .SaveChanges();
            return await Task.FromResult(true);
        }

        public async Task<List<Department>> GetAll()
        {
            return await Task.FromResult(_payrollContext
                .Departments
                .ToList());
        }

        public async Task<Department?> GetById(Guid departmentId)
        {
            var getId = await _payrollContext
                .Departments
                .Where( s => s.DepartmentId == departmentId )
                .FirstOrDefaultAsync();

            return getId;
        }

        public async Task<Department> Update(Department department)
        {
            var update = _payrollContext.Update(department);
            _payrollContext.SaveChanges();
            return await Task.FromResult(department);
        }
    }
}
