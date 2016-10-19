using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLibrary.BLL.Custom_Validation
{
    /// <summary>
    /// Specify whether username is unique
    /// </summary>
    public class UniqueUserNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            User obj = new User();
            if (obj.IfUserNameIsUnique(value.ToString()))
                return ValidationResult.Success;
            else
                return new ValidationResult("UserName Is Already Exists");
        }
    }
}
