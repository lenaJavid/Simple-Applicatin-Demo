using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.DLL
{
    class User
    {
        OrganizationEntities OE = new OrganizationEntities();

        protected internal bool AuthenticateUser(string userName, string password)
        {
            try
            {
                if (OE.Users.Where(x => x.UserName == userName && x.Password == password).Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        protected internal bool Insert(string userName, string password)
        {
            try
            {
                AuthenticationLibrary.Model.User obj = new AuthenticationLibrary.Model.User();
                obj.UserName = userName;
                obj.Password = password;

                OE.Users.Add(obj);
                OE.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        protected internal bool IfUserNameIsUnique(string userName)
        {
            try
            {
                if (OE.Users.Where(x => x.UserName == userName).Count() == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        protected internal bool IfEmailAddressIsUnique(string email)
        {
            try
            {
                if (OE.Users.Where(x => x.Email == email).Count() == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
