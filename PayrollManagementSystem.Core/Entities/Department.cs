namespace PayrollManagementSystem.Core.Entities
{
    public class Department : Entity  
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }
        //one to many Relationship
        public ICollection<Employee>? Employees { get; set; }
    }
}
