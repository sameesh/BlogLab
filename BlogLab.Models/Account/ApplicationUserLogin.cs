using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage ="User name required")]
        [MinLength(5,ErrorMessage ="Must be atleast 5-20 characters")]
        [MaxLength(20,ErrorMessage ="User name cannot exceed 20 characters")]
        public string  Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        [MinLength(10, ErrorMessage = "Must be atleast 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Password cannot exceed 20 characters")]
        public string  Password { get; set; }

    }
}
