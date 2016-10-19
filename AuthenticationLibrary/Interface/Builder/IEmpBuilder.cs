using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.Interface.Builder
{
    public interface IEmpBuilder
    {
        IEmpBuilder SetEName(String name);
        IEmpBuilder SetESal(Decimal esal);

        IEmpBuilder SetEGen(bool isman);

        IEmpBuilder SetEDOB(DateTime date);

        IEmpBuilder SetDepartmentId(int did);

        Employee GetResult();
    }
}
