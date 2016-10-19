using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.Interface
{
    public interface IUserRole
    {
        IEnumerable<UserRole> GetUserRoles(int userId);
        string[] GetUserRoles(string userName);
        bool Insert(User user, Role role);
        IEnumerable<UserRole> GetUsersByRoleId(int roleId);
    }
}
