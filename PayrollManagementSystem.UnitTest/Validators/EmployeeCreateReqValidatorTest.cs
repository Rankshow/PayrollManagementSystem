using PayrollManagementSystem.Services.Contracts.Employee;
using FluentValidation.TestHelper;
using Xunit;

namespace PayrollManagementSystem.UnitTest.Validators
{
    
    public class EmployeeCreateReqValidatorTest
    {
        private EmployeeCreateReqValidator _validator;
        public EmployeeCreateReqValidatorTest()
        {      
            _validator = new EmployeeCreateReqValidator();  
        }

        [Fact]
        public void NameValidator_EmptyTest_Should_Fail()
        {
            //Arange
            var employee = new EmployeeCreateReq
            {
                Name = string.Empty,
                Gender = "Male",
                Address = "Flick Avenue",
                Email = "ranag@gmail.com",
                PhoneNumber = "+234848849392",
                Age = 20
            };

            //Act
            var result = _validator.TestValidate(employee);

            //Assert
            result.ShouldHaveValidationErrorFor(m => m.Name);
        }
        [Fact]
        public void GenderValidator_EmptyTest_Should_Fail()
        {
            var employee = new EmployeeCreateReq
            {
                Name = "Micheal",
                Gender = "",
                Address = "Flick Avenue",
                Email = "ranag@gmail.com",
                PhoneNumber = "+234848849392",
                Age = 20
            };

            var result = _validator.TestValidate(employee);

            result.ShouldHaveValidationErrorFor(m => m.Gender);
        }
        
        [Fact]
        public void GenderValidator_Not_EmptyTest_Should_Pass()
        {
            var employee = new EmployeeCreateReq
            {
                Name = "Micheal",
                Gender = "Male",
                Address = "Flick Avenue",
                Email = "ranag@gmail.com",
                PhoneNumber = "+234848849392",
                Age = 20
            };

            var result = _validator.TestValidate(employee);
            
            result.ShouldNotHaveValidationErrorFor(m => m.Gender);
        }
    }
}
