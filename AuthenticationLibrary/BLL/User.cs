using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Interface;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.BLL
{
    public class User : IUser
    {
        public bool AuthenticateUser(string userName, string password)
        {
            try
            {
                DLL.User obj = new DLL.User();
                return obj.AuthenticateUser(userName, password);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Insert(string userName, string password)
        {
            try
            {
                if (userName != String.Empty && password != String.Empty)
                {
                    DLL.User employee = new DLL.User();
                    return employee.Insert(userName, password);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool IfUserNameIsUnique(string userName)
        {
            try
            {
                DLL.User obj = new DLL.User();
                return obj.IfUserNameIsUnique(userName);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool IfEmailAddressIsUnique(string email)
        {
            try
            {
                DLL.User obj = new DLL.User();
                return obj.IfEmailAddressIsUnique(email);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
