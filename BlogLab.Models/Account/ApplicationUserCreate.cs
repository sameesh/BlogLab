using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate:ApplicationUserLogin
    {
        [Required(ErrorMessage = "User name required")]
        [MinLength(10, ErrorMessage = "Must be atleast 10-20 characters")]
        [MaxLength(30, ErrorMessage = "User name cannot exceed 30 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email required")]
        [MinLength(30, ErrorMessage = "Can be atmost  30 characters")]
        [EmailAddress( ErrorMessage = "InValid Email Format")]
        public string Email { get; set; }
    }
}
