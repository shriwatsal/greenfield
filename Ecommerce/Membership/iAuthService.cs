using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    internal interface iAuthService
    {

        bool Login(string username, string password);
        bool Register(User user);

        bool Forgot(string username, string password);

        bool ResetPassword(string username, string oldpassword,string newpassword);

    }
}
