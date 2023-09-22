using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Please enter your full name")]
        [Display(Name = "Full name")]
        /*[UserNameValidator]*/
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a strong password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(5)]
        public string Password { get; set; }

        
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        
        public string ConfirmPassword { get; set; }



    }
}
