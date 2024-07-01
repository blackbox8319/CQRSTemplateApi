using Application.Queries.Authentication;
using FluentValidation;

namespace Application.Validators
{
    public class LoginQueryValidator : AbstractValidator<LoginQuery>
    {
        public LoginQueryValidator() 
        {
            RuleFor(k => k.UserName)
                       .NotEmpty()
                       .NotNull()
                       .WithMessage("UserId should be valid");
            RuleFor(k => k.Password)
                   .NotEmpty()
                   .NotNull()
                   //.Matches("(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&])[A-Za-z\\d$@$!%*?&].{8,}")
                   //.Length(8).WithMessage("Password should be of minimum 8 characters")
                   .WithMessage("Password should be valid");
            //RuleFor(k => k.Role)
            //       .NotEmpty()
            //       .NotNull()
            //       .WithMessage("Role should be valid");

        }
    }
}
