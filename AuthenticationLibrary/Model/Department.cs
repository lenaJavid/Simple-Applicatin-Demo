//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthenticationLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.Web.Script.Serialization;
    
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.tbl_Emp = new HashSet<Employee>();
        }
    
        public int Did { get; set; }
        public string Dname { get; set; }
        public string HOB { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [ScriptIgnore]
        public virtual ICollection<Employee> tbl_Emp { get; set; }
    }
}