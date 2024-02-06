using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using PayrollManagementSystem.Presentation.Controllers;
using PayrollManagementSystem.Services.Contracts.Employee;
using PayrollManagementSystem.Services.Interfaces;
using Shouldly;
using Xunit;

namespace PayrollManagementSystem.UnitTest.Controllers
{
    public class EmployeeControllerTest
    {
        private readonly Mock<IEmployeeService> _mockEmployeeService;
        private readonly Mock<ILogger<EmployeeController>> _mockLoggerService;
        private readonly EmployeeCreateReqValidator _validator;
        public EmployeeControllerTest()
        {
            _mockEmployeeService = new Mock<IEmployeeService>();
            _validator = new EmployeeCreateReqValidator();
            _mockLoggerService = new Mock<ILogger<EmployeeController>>();
        }
        //Testing for two conditions,
        //1.Once, I put my valid input it will pass
        //2.If i didn't put any valid input it will fail.
        [Fact]
        public void EmployeeCreate_ValidInput_ShouldPass()
        {
            //Arrange
            _mockEmployeeService.Setup(m => m.Create(It.IsAny<EmployeeCreateReq>()))
            .Returns(new EmployeeRsp<EmployeeDto>
            {
                Code = "200",
                Result = new EmployeeDto
                {
                    
                }
            });

            var employeeController = new EmployeeController(
                _mockEmployeeService.Object,
                _validator,
                _mockLoggerService.Object
                );

            var employeeReq = new EmployeeCreateReq
            {
                Name = "Felix",
                Gender = "Male",
                Address = "Flick Avenue",
                Email = "ranag@gmail.com",
                PhoneNumber = "+234848849392",
                Age = 20                    
            };
            //Act
            var result = employeeController.Create(employeeReq);

            //Assert
            result.ShouldBeOfType<ActionResult<BaseResponse>>();
        }
        [Fact]
        public void EmployeeCreate_InValidInput_ShouldFail()
        {
            //Arrange
            _mockEmployeeService.Setup(m => m.Create(It.IsAny<EmployeeCreateReq>()))
            .Returns(new EmployeeRsp<EmployeeDto>
            {
                Code = "200",
                Result = new EmployeeDto
                {
                    
                }
            });

            //passing our Moq dependencies
            var employeeController = new EmployeeController(
                _mockEmployeeService.Object,
                _validator,
                _mockLoggerService.Object
                );

            var employeeReq = new EmployeeCreateReq
            {
                Name = "",
                Gender = "Male",
                Address = "Flick Avenue",
                Email = "ranag@gmail.com",
                PhoneNumber = "+234848849392",
                Age = 20                    
            };
            //Act
            var result = employeeController.Create(employeeReq);

            //Assert
            result.ShouldBeOfType<ActionResult<BaseResponse>>();
            (result as ActionResult<BaseResponse>).ShouldNotBeAssignableTo<Ok>();
        }
    }
}
