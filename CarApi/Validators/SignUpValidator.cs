using CarApi.DTOs;
using FluentValidation;

namespace CarApi.Validators
{
    public class SignUpValidator : AbstractValidator<SignUpDto>
    {
        public SignUpValidator() { 
            RuleFor(x=> x.password)
                    .MinimumLength(8)
                    .WithMessage("Password cannot be less than 8 characters");
        }
    }
}
