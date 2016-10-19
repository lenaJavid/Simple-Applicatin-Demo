using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace AuthenticationLibrary.DLL
{
    class Dep
    {
        OrganizationEntities OE = new OrganizationEntities();

        protected internal IEnumerable<Department> GetAllDep()
        {
            try
            {
                IEnumerable<Department> deps = deps = OE.Departments.ToList();
                return deps;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        protected internal Department GetDepById(int depId)
        {
            try
            {
                Department deps = OE.Departments.Where(x => x.Did == depId).FirstOrDefault();

                return deps;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected internal bool Insert(Department dep)
        {
            try

            {
                OE.Departments.Add(dep);
                OE.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        protected internal bool Update(int id, Department dep)
        {
            try
            {
                OE.Entry(dep).State = EntityState.Modified;
                OE.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public bool DepartmentExists(int? depId)
        {
            try
            {
                if (depId != null)
                {
                    DLL.Dep obj = new DLL.Dep();
                    return obj.DepartmentExists(depId);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        protected internal bool Delete(int? depId)
        {
            try
            {
                Department department = OE.Departments.Find(depId);
                if (department == null)
                {
                    return false;
                }
                else
                {
                    OE.Departments.Remove(department);
                    OE.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
