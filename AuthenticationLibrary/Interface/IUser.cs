using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.Interface
{
    public interface IUser
    {
        bool AuthenticateUser(string userName, string password);
        bool Insert(string userName, string password);
        bool IfUserNameIsUnique(string userName);
        bool IfEmailAddressIsUnique(string email);
    }
}
