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
        public static bool LoginCheking(string LoginCheck, string PasswordCheck, UnitOfWork unitOfWork)
        {
            try
            {
                var User = unitOfWork.Users.First(x => x.Login == LoginCheck);
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
       
        public static User GetUser(string LoginCheck, UnitOfWork unitOfWork)
        {
            return unitOfWork.Users.First(x => x.Login == LoginCheck);
        }

        public static bool LoginExists(string login, UnitOfWork unitOfWork)
        {
            return unitOfWork.Users.First(x => x.Login == login) != null;
        }
    }
}
 