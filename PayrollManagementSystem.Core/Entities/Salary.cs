namespace PayrollManagementSystem.Core.Entities
{
    public class Salary : Entity
    {
        public Guid SalaryId { get; set; }
        public double Amount { get; set; }
        public double Bonus { get; set; }

        public Employee? Employees {  get; set; }
    }
}
