using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLibrary.ModelMeta
{
    public class DepMeta
    {
        //[ReadOnly(true)]
        [Editable(false)]
        public int Did { get; private set; }
        public string Dname { get; set; }
        public string HOB { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> Active { get; set; }
    }

    [MetadataTypeAttribute(typeof(DepMeta))]
    public partial class Departmnet
    {
        
    }
}
