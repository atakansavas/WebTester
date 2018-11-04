using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities.Account;
using System.Linq;

namespace Mega.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public User CheckUsernamePassword(string username, string password)
        {
            using (var cx = new MegaContext())
            {
                return cx.UserSet.FirstOrDefault(p => p.Username == username && p.Password == password && p.IsActive);
            }
        }
    }
}
