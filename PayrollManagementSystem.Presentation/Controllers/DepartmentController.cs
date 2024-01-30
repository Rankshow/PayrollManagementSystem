using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagementSystem.Services.Contracts.Department;
using PayrollManagementSystem.Services.Contracts.Employee;
using PayrollManagementSystem.Services.Interfaces;

namespace PayrollManagementSystem.Presentation.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly ILogger<DepartmentController> _logger;
        public DepartmentController(IDepartmentService departmentService, ILogger<DepartmentController> logger)
        {
            _logger = logger;
            _departmentService = departmentService;
        }
        [HttpPost]
        public async Task<ActionResult<BaseResponse>> Create([FromBody]DepartmentCreateReq req) 
        {
            _logger.LogInformation("Executing Add department");
            return await _departmentService.Create(req);
        }
        [HttpGet]
        public async Task<ActionResult<BaseResponse>> GetAll()
        {
            _logger.LogInformation("Executing all deepartments");
            return await _departmentService.GetAll();
        }
    }
}

