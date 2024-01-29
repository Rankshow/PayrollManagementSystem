using Microsoft.EntityFrameworkCore;
using PayrollManagementSystem.Core.Entities;
using PayrollManagementSystem.Core.Interfaces;
using PayrollManagementSystem.Repositories.Data;


namespace PayrollManagementSystem.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly PayrollContext _payrollContext;
        public EmployeeRepository(PayrollContext payrollContext)
        {
            _payrollContext = payrollContext;
        }

        public async Task<Employee> Create(Employee employee)
        {
            _payrollContext.Add(employee);
            _payrollContext.SaveChanges();  
            return await Task.FromResult(employee);
        }

        public async Task<bool> Delete(Guid employeeId)
        {
            var employee = await _payrollContext
                .Employees
                .Where(y => y.EmployeeId == employeeId)
                .FirstOrDefaultAsync();
                
             _payrollContext.Employees.Remove(employee ?? new Employee());
             _payrollContext.SaveChanges();
             return await Task.FromResult(true);  
            
        }

        public async Task<List<Employee>> GetAll()
        {
             return await Task.FromResult(_payrollContext
                 .Employees
                 .ToList()); 
        }

        public async Task<Employee?> GetById(Guid employeeId)
        {
            var employee =  await _payrollContext
                .Employees.Where(x => x.EmployeeId == employeeId)
                .FirstOrDefaultAsync();

            return employee;  
        }
        public Task<Employee> Update(Employee employee)
        {
            var update = _payrollContext.Employees.Update(employee);
            _payrollContext.SaveChanges(); 
            return Task.FromResult(employee);
        }
    }
}
