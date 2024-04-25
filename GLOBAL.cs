using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public static class GLOBAL
    {
        private static string username;
        private static string password;
        public static string Username { get { return username; } set { username = value; } }
        public static string Password { get { return password; } set { password = value; } }
    }
}
