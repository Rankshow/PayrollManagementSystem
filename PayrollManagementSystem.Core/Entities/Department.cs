namespace PayrollManagementSystem.Core.Entities
{
    public class Department
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set; }
        //one to many Relationship
        public ICollection<Employee>? Employees { get; set; }
    }
}
