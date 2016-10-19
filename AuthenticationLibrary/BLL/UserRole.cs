using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Interface;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.BLL
{
    public class UserRole : IUserRole
    {
        public IEnumerable<AuthenticationLibrary.Model.UserRole> GetUserRoles(int userId)
        {
            try
            {
                DLL.UserRole obj = new DLL.UserRole();
                return obj.GetUserRoles(userId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string[] GetUserRoles(string userName)
        {
            try
            {
                DLL.UserRole obj = new DLL.UserRole();
                return obj.GetUserRoles(userName);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Insert(AuthenticationLibrary.Model.User user, AuthenticationLibrary.Model.Role role)
        {
            try
            {
                if (user != null && role != null)
                {
                    DLL.UserRole userRole = new DLL.UserRole();
                    return userRole.Insert(user, role);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<AuthenticationLibrary.Model.UserRole> GetUsersByRoleId(int roleId)
        {
            try
            {
                DLL.UserRole obj = new DLL.UserRole();
                return obj.GetUsersByRoleId(roleId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
