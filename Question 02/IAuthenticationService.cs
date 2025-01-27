using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Question_02
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string UN, string Pass);
        bool AuthorizeUser(string UN, string role);
    }
}
