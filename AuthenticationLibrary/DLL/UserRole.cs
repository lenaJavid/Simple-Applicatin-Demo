using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.DLL
{
    class UserRole
    {
        OrganizationEntities OE = new OrganizationEntities();

        protected internal IEnumerable<AuthenticationLibrary.Model.UserRole> GetUserRoles(int userId)
        {
            try
            {
                return OE.UserRoles.Include("tbl_Role").Where(x => x.UserId == userId).ToList();;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected internal string[] GetUserRoles(string userName)
        {
            try
            {
                AuthenticationLibrary.Model.User user = OE.Users.Where(x => x.UserName == userName).FirstOrDefault(); 
                if(user!=null)
                {
                    var rolesList = new List<string>();
                    foreach(var userRole in user.UserRoles)
                    {
                        rolesList.Add(userRole.RoleId.ToString());                       
                    }

                    String listString = String.Join(", ", rolesList);
                    string[] rolesString = listString.Split(',');
                    return rolesString;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected internal bool Insert(AuthenticationLibrary.Model.User user, AuthenticationLibrary.Model.Role role)
        {
            try
            {
                AuthenticationLibrary.Model.UserRole obj = new AuthenticationLibrary.Model.UserRole();
                obj.Role = new AuthenticationLibrary.Model.Role { RoleId = role.RoleId, RoleName = role.RoleName };
                obj.User = new AuthenticationLibrary.Model.User { UserId = user.UserId, Password = user.Password, UserName = user.UserName }; 

                OE.UserRoles.Add(obj);
                OE.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        protected internal IEnumerable<AuthenticationLibrary.Model.UserRole> GetUsersByRoleId(int roleId)
        {
            try
            {
                return OE.UserRoles.Where(x => x.RoleId == roleId).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
