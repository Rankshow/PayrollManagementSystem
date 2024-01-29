using Microsoft.EntityFrameworkCore;
using PayrollManagementSystem.Core.Entities;

namespace PayrollManagementSystem.Repositories.Data
{
    public class PayrollContext : DbContext
    {
        public PayrollContext(DbContextOptions<PayrollContext> options)
            :base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }  
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Salary> Salaries { get; set; } 
        public DbSet<Payroll> Payrolls { get; set; }    
    }

}
