using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Interface;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.BLL
{
    public class Role : IRole
    {
        public bool Insert(string roleName)
        {
            try
            {
                if (roleName != String.Empty)
                {
                    DLL.Role roles = new DLL.Role();
                    return roles.Insert(roleName);
                }
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
