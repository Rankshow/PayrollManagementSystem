using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSystem.Core.Entities
{
    public class Payroll : Entity
    {
        public Guid PayrollId { get; set; }
        public Guid SalarId { get; set; }
        public Guid LeaveId { get; set; }
        public string Report {  get; set; } = string.Empty; 
        public double TotalAmount {  get; set; }
    }
}
