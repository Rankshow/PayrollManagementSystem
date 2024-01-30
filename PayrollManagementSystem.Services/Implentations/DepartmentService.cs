using PayrollManagementSystem.Core.Interfaces;
using PayrollManagementSystem.Services.Contracts.Department;
using PayrollManagementSystem.Services.Extension;
using PayrollManagementSystem.Services.Interfaces;


namespace PayrollManagementSystem.Services.Implentations
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<DepartmentRsp<DepartmentDto>> Create(DepartmentCreateReq req)
        {
            var createDep = req.AsEntity();
            await _departmentRepository.Create(createDep);

            return new DepartmentRsp<DepartmentDto>
            {
                Code = "200",
                Message = string.Empty,
            };     
        }

        public async Task<DepartmentRsp<bool>> Delete(Guid employeeId)
        {
             await _departmentRepository.Delete(employeeId);
            return new DepartmentRsp<bool>
            {
                Code = "200",
                Message = string.Empty,
            };
        }

        public async Task<DepartmentRsp<List<DepartmentDto>>> GetAll()
        {
            var result = await _departmentRepository.GetAll();

            return new DepartmentRsp<List<DepartmentDto>>
            {
                Code = "200",
                Message = string.Empty,
                Result = result.AsDto()
            };
        }

        public async Task<DepartmentRsp<DepartmentDto>> GetById(Guid departmentId)
        {
            var result = await _departmentRepository.GetById(departmentId);

            if (result == null)
            {
                return new DepartmentRsp<DepartmentDto>
                {
                    Code = "404",
                    Message = "Department is not found."
                    
                };

            }
                return new DepartmentRsp<DepartmentDto>
                {
                    Code = "200",
                    Message = string.Empty, 
                    Result = result.AsDto()
                };
        }

        public async Task<DepartmentRsp<DepartmentDto>> Update(DepartmentCreateReq req)
        {
            var update = req.AsEntity();
            await _departmentRepository.Update(update);

            return new DepartmentRsp<DepartmentDto>
            {
                Code = "200",
                Message = string.Empty,
                Result = update.AsDto()
            };
        }
    }
}
