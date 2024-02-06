using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PayrollManagementSystem.Services.Contracts.Employee;
using PayrollManagementSystem.Services.Interfaces;

namespace PayrollManagementSystem.Presentation.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;   
        private readonly IEmployeeService _employeeService;
        private readonly IValidator<EmployeeCreateReq> _validator;
        public EmployeeController(IEmployeeService employeeService, IValidator<EmployeeCreateReq> validator , ILogger<EmployeeController> logger)
        { 
            _logger = logger;
            _employeeService = employeeService;
            _validator = validator;
        }

        [HttpPost]
        public ActionResult<BaseResponse> Create(
            [FromBody]EmployeeCreateReq req) 
        {
         
            var validatorCheck = _validator.Validate(req);

            if (!validatorCheck.IsValid) 
            {
                return BadRequest(validatorCheck);
            }

            return Ok(_employeeService.Create(req));
           }

        [HttpGet]
        public async Task<ActionResult<BaseResponse>> GetAll() 
        {
            return await _employeeService.GetAll();
        }
        [HttpGet]
        [Route("{employeeId}")]
        public async Task<ActionResult<BaseResponse>> GetById(Guid employeeId) 
        {
            return await _employeeService.GetById(employeeId);
        }
        [HttpPut]
        public async Task<ActionResult<BaseResponse>> Update(
            [FromRoute]Guid employeeId, 
            [FromBody]EmployeeUpdateReq req)
        {
            return await _employeeService.Update(req);
        }
        [HttpDelete]
        [Route("{employeeId}")]
        public async Task<ActionResult<BaseResponse>> Delete(Guid employeeId)
        {
            return await _employeeService.Delete(employeeId);
        }

    }
}
