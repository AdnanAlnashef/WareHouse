using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models;

namespace WareHouse.Helpers.Session
{
    public static class AppSession
    {
        public static User CurrentUser { get; private set; }
        public static bool IsAuthenticated => CurrentUser != null;


        public static void Login(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
