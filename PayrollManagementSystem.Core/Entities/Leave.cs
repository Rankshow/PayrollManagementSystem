namespace PayrollManagementSystem.Core.Entities
{
    public class Leave : Entity
    {
        public Guid LeaveId { get; set; }
        public string Purpose {  get; set; } = string.Empty;
        public bool Status { get; set; } 

        public Employee? Employee { get; set; }
    }
}
