using PayrollManagementSystem.Core.Entities;
using PayrollManagementSystem.Services.Contracts.Department;


namespace PayrollManagementSystem.Services.Extension
{
    public static class DepartmentExtension
    {
        public static Department AsEntity(this DepartmentCreateReq req)
        {
            return new Department
            {
                //DepartmentId = req.DepartmentId,
                Name = req.Name,
                Description = req.Description,
                CreatedBy = "Micheal",
                CreatedDate = DateTime.Now,
                ModifiedBy = "Admin",
                ModifiedDate = DateTime.Now,
            };
        }
        public static DepartmentDto AsDto(this Department dto)
        {
            return new DepartmentDto
            {
                DepartmentId = dto.DepartmentId,
                Name = dto.Name,
                Description = dto.Description,
            };
        }
        public static List<DepartmentDto> AsDto(this List<Department> entities) 
        {
            var departmentDtos = new List<DepartmentDto>();
            foreach (var entity in entities)
            {
                departmentDtos.Add(entity.AsDto());
            }
            return departmentDtos;  
        }

        public static Department AsEntity(this DepartmentUpdateReq req)
        {
            return new Department
            {
                DepartmentId = req.DepartmentId,
                Name = req.Name,    
                Description = req.Description,
            };
        }
    }
}
