using PayrollManagementSystem.Core.Entities;
using PayrollManagementSystem.Services.Contracts.Employee;

namespace PayrollManagementSystem.Services.Extension
{
    public static class EmployeeExtension
    {
        public static Employee AsEntity(this EmployeeCreateReq req)
        {
            return new Employee
            {
                Name = req.Name,
                Gender = req.Gender,
                Address = req.Address,
                Email = req.Email,  
                Age = req.Age,
                PhoneNumber = req.PhoneNumber,
                CreatedBy = "Micheal",
                CreatedDate = DateTime.Now,
                ModifiedBy = "Admin",
                ModifiedDate = DateTime.Now,
            };
        }
        public static EmployeeDto AsDto(this Employee entity)
        {
            return new EmployeeDto
            {
                EmployeeId = entity.EmployeeId, 
                Name = entity.Name,
                Gender = entity.Gender,
                Address = entity.Address,
                Email = entity.Email,  
                Age = entity.Age,
                PhoneNumber = entity.PhoneNumber,
            };
        }
        public static List<EmployeeDto> AsDto(this List<Employee> entities)
        {
            var employeeDtos = new List<EmployeeDto>();

            foreach (Employee entity in entities)
            { 
                employeeDtos.Add(entity.AsDto());
            }
            return employeeDtos;
        }
        public static Employee AsEntity(this EmployeeUpdateReq req)
        {
            return new Employee
            {
                EmployeeId = req.EmployeeId, 
                Name = req.Name,
                Gender = req.Gender,
                Address = req.Address,
                Email = req.Email,
                Age = req.Age,
                PhoneNumber = req.PhoneNumber,
                CreatedBy = "Micheal",
                CreatedDate = DateTime.Now,
                ModifiedBy = "Admin",
                ModifiedDate = DateTime.Now,
            };
        }
    }
}
