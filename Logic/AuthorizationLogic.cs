using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryV1;
using System.Data.Entity;


namespace Logic
{
    public class AuthorizationLogic
    {       
        public static bool LoginCheking(string LoginCheck, string PasswordCheck, DbSet<User> UsersAccounts)
        {
            try
            {
                var User = UsersAccounts.First(x => x.Login == LoginCheck);
                if (User.Password == PasswordCheck)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }          
        }

    }
}
 