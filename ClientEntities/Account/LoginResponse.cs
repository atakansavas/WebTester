using System;
using System.Collections.Generic;
using System.Text;

namespace ClientEntities.Account
{
    public class LoginResponse
    {
        public string Token { get; set; }
        /// <summary>
        /// 1 = Backoffice
        /// 2 = Client
        /// </summary>
        public int UserType { get; set; }
    }
}
