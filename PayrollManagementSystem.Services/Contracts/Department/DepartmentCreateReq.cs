using System.ComponentModel.DataAnnotations;

namespace PayrollManagementSystem.Services.Contracts.Department
{
    public class DepartmentCreateReq
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
