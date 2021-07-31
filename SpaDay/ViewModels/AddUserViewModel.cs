using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel { 

        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "UserName must be between 5 to 15 characters")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 20 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 20 characters")]
        [Compare("Password", ErrorMessage ="Password do not match" )]
        public string VerifyPassword { get; set; }

    }
}
