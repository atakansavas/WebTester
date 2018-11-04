using ClientEntities.Account;
using Mega.Engine.Interfaces;
using Mega.Engine.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mega.Engine.Account
{
    public class AccountEngine : IAccountEngine
    {
        
        public LoginResponse Login(LoginRequest request)
        {
            var a = new LoginRequestValidation();


            var response = new LoginResponse();

            return response;
        }
    }
}
