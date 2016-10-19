using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyTestApplication.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User Name is required.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }


}
