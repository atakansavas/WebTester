using BusinessEntities.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mega.Repository
{
    public interface IAccountRepository : MegaRepository<User>
    {
        User CheckUsernamePassword(string username, string password);
    }
}
