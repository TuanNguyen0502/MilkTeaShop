using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public class AccountEventArg
    {
        public string Username { get; } 
        public string Password { get; } 
        public string EmpID { get; }
        public AccountEventArg(string username, string password, string empID)
        {
            Username=username;
            Password=password;
            EmpID=empID;
        }
    }
}
