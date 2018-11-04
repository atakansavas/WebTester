using ClientEntities.Account;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mega.Engine.Validations
{
    public class LoginRequestValidation : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidation()
        {
            RuleFor(reg => reg.Username).NotEmpty();
            RuleFor(reg => reg.Password).NotEmpty();
        }
    }
}
