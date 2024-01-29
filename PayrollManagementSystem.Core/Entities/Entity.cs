namespace PayrollManagementSystem.Core.Entities
{
    public abstract class Entity
    {
        public Guid EmployeeId { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set;}
    }
}
