using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLibrary.BLL.Custom_Validation
{
    /// <summary>
    /// specify that the email address is unique
    /// </summary>
    class UniqueEmailAddressAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            User obj = new User();
            if (obj.IfEmailAddressIsUnique(value.ToString()))
                return ValidationResult.Success;
            else
                return new ValidationResult("Email Is Already Exist");
        }
    }
}
