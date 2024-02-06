using PayrollManagementSystem.Core.Interfaces;
using PayrollManagementSystem.Services.Contracts.Employee;
using PayrollManagementSystem.Services.Extension;
using PayrollManagementSystem.Services.Interfaces;

namespace PayrollManagementSystem.Services.Implentations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public EmployeeRsp<EmployeeDto> Create(EmployeeCreateReq req)
        {
            var createdEmp = req.AsEntity();
            _employeeRepository.Create(createdEmp);

            return new EmployeeRsp<EmployeeDto>
            {
                Code = "200",
                Message = string.Empty
            };
        }

        public async Task<EmployeeRsp<bool>> Delete(Guid employeeId)
        {
            var todelete = await _employeeRepository.Delete(employeeId);

            return new EmployeeRsp<bool>
            {
                Code = "200",
                Message = string.Empty,
                Result = todelete
            };
        }

        public async Task<EmployeeRsp<List<EmployeeDto>>> GetAll()
        {
            var result = await _employeeRepository.GetAll();

            return new EmployeeRsp<List<EmployeeDto>>
            {
                Code = "200",
                Message = "Success",
                Result = result.AsDto()
            };
        }

        public async Task<EmployeeRsp<EmployeeDto>> GetById(Guid employeeId)
        {
            var result = await _employeeRepository.GetById(employeeId);

            if(result == null) 
            {
                return new EmployeeRsp<EmployeeDto>
                {
                    Code = "404",
                    Message = "Employee is not found",
                };
            }

            return new EmployeeRsp<EmployeeDto>
            {
                Code = "200",
                Message = "Success",
                Result = result.AsDto()
            };
        }

        public async Task<EmployeeRsp<EmployeeDto>> Update(EmployeeUpdateReq req)
        {
            var toUpdate = req.AsEntity();
            await _employeeRepository.Update(toUpdate);

            return new EmployeeRsp<EmployeeDto>
            {
                Code = "200",
                Message = "Success",
                Result = toUpdate.AsDto()
            };
        }
    }
}
