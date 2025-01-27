using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Question_02
{
    internal class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService(string UN,string Pass,string role)
        {
            UserName = UN;
            Role = role;
            password = Pass;
        }
        public string UserName { get; set; }
        public string password { get; set; }
        public string Role { get; set; }
        public bool AuthenticateUser(string UN, string Pass)
        {
            return UN == UserName && Pass == password; 
        }

        

        public bool AuthorizeUser(string UN, string role)
        {
            return UN == UserName && role==Role ;
        }

        
    }
}
