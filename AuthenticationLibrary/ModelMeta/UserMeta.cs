using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.BLL.Custom_Validation;

namespace AuthenticationLibrary.ModelMeta
{
    public class UserMeta
    {
        [Required]
        [UniqueUserName]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [EmailAddress]
        [UniqueEmailAddress]
        public string Email { get; set; }
    }

    [MetadataTypeAttribute(typeof(UserMeta))]
    public partial class User
    {
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
