using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.Interface
{
    public interface IDep
    {
        IEnumerable<Department> GetAllDep();
        Department GetDepById(int depId);
        bool Insert(Department dep);
        bool Update(int id, Department dep);
        bool DepartmentExists(int? depId);
        bool Delete(int? depId);
    }
}
