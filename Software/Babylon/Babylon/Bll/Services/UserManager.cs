using Dll.Model;
using Bll.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
    public static class UserManager
    {
        private static UnitOfWork UnitOfWork = new UnitOfWork(new AppDbContext());

        public static User LoggedUser { get; private set; }

        public static LoginResult LogInUser(string username, string password)
        {
            var user = UnitOfWork.Users.FindEmployee(username, password);
            //var user = UnitOfWork.Users.Find(u => u.Password == password && u.UserName == username);

            if (user == null)
            {
                return LoginResult.NotFound;
            }
            else if (user.Locked)
            {
                return LoginResult.Inactive;
            }
            else
            {
                LoggedUser = user;
                return LoginResult.Succesful;
            }
        }
        public static void LogOut()
        { 
            LoggedUser = null;
        }
    }
}
