using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryV1;

namespace Logic
{
    public class AuthorizationLogic
    {
        public string LoginCheck;
        public string PasswordCheck;
        List<User> UsersAccounts = new List<User>();

        public bool LoginCheking()
        {
            try
            {
                var User = UsersAccounts.Find(x => x.Login == LoginCheck);
                if (User.Password == PasswordCheck)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
 