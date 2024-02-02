using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSystem.Services.Contracts.Employee
{
    public class EmployeeUpdateReqValidator : AbstractValidator<EmployeeUpdateReq>
    {
        public EmployeeUpdateReqValidator() 
        {
            RuleFor(x => x.EmployeeId)
                .NotEmpty()
                .WithMessage("Employee Id is required");

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
