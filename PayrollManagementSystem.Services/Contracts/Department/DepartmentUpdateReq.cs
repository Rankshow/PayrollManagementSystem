namespace PayrollManagementSystem.Services.Contracts.Department
{
    public class DepartmentUpdateReq : DepartmentCreateReq
    {
        public Guid DepartmentId { get; set; }
    }
}
