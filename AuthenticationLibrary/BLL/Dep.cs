using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Interface;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.BLL
{
    public class Dep : IDep
    {
        public IEnumerable<Department> GetAllDep()
        {
            try
            {
                DLL.Dep obj = new DLL.Dep();
                return obj.GetAllDep();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Department GetDepById(int depId)
        {
            try
            {
                DLL.Dep obj = new DLL.Dep();
                return obj.GetDepById(depId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Insert(Department dep)
        {
            try
            {
                if (dep != null)
                {
                    DLL.Dep department = new DLL.Dep();
                    return department.Insert(dep);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<Employee> GetEmpByDepId(int depId)
        {
            try
            {
                DLL.Emp obj = new DLL.Emp();
                return obj.GetEmpByDepId(depId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(int id, Department dep)
        {
            try
            {
                if (id != dep.Did)
                {
                    return false;
                }

                if (dep.Did.ToString() != String.Empty && dep.Dname != String.Empty)
                {
                    DLL.Dep department = new DLL.Dep();
                    return department.Update(id, dep);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public  bool DepartmentExists(int? depId)
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

        public bool Delete(int? depId)
        {
            try
            {
                if (depId != null)
                {
                    DLL.Dep department = new DLL.Dep();
                    return department.Delete(depId);
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
