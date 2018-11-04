using BusinessEntities.Account;
using ClientEntities.Account;
using Mega.Engine.Interfaces;
using Mega.Engine.Validations;
using Mega.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Mega.Engine.Account
{
    public class AccountEngine : IAccountEngine
    {
        IAccountRepository _accountRepository;

        public AccountEngine(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public LoginResponse Login(LoginRequest request)
        {
            var a = new LoginRequestValidation();
            //request.Password = request.Password.ToString()

            var response = new LoginResponse();
            var user = _accountRepository.CheckUsernamePassword(request.Username, request.Password);
            if (user != null)
            {
                response.UserType = user.UserTypeId;
            }
            //var user = 
            return response;
        }

        private string GetToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

    }
}
