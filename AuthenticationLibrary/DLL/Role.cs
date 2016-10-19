using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.DLL
{
    class Role
    {
        OrganizationEntities OE = new OrganizationEntities();

        protected internal bool Insert(string roleName)
        {
            try
            {
                AuthenticationLibrary.Model.Role obj = new AuthenticationLibrary.Model.Role();
                obj.RoleName = roleName;

                OE.Roles.Add(obj);
                OE.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
