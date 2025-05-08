using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Core.DTO;
using FluentValidation;

namespace eCommerce.Core.Validators;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        //Email
        RuleFor(temp => temp.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Invalid email address format");

        //Password
        RuleFor(temp => temp.Password)
            .NotEmpty().WithMessage("Password is required");

        //PersonName
        RuleFor(temp => temp.PersonName)
            .NotEmpty().WithMessage("Person name is required");

        //Gender
        RuleFor(temp => temp.Gender)
            .NotNull().WithMessage("Gender is required");
    }
}
