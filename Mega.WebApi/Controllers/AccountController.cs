using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientEntities.Account;
using Mega.Engine.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Mega.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountEngine _accountEngine;
        public AccountController (IAccountEngine accountEngine)
        {
            _accountEngine = accountEngine;
        }
        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpPost]
        [Route("Login")]
        public LoginResponse Login(LoginRequest request)
        {
            return _accountEngine.Login(request);
        }

        //public LoginResponse Index(LoginRequest request)
        //{
        //    //using (var db = new MegaContext())
        //    //{
        //    //    var a = db.UserSet.ToList();
        //    //}
        //    return null;
        //}
    }
}