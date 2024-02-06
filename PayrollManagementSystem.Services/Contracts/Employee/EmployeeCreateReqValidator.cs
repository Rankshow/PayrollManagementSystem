using FluentValidation;
namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class EmployeeCreateReqValidator : AbstractValidator<EmployeeCreateReq>
    {
        public EmployeeCreateReqValidator() 
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .Length(30)
                .WithMessage("Name is required");

            RuleFor(s => s.Gender)
                .NotEmpty()
                .WithMessage("Gender is required");

            RuleFor(s => s.Address)
                .NotEmpty()
                .WithMessage("Address is required"); 
            
            RuleFor(s => s.Email)
                .NotEmpty()
                .WithMessage("Email is required");

            RuleFor(s => s.PhoneNumber)
                .NotEmpty()
                .WithMessage("Phone number is required");
        }
    }
}
