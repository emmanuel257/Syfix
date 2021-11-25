using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SYFIX.Models
{
    public class CustomerResponse
    { 
        [Required(ErrorMessage = "Please Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter your Email")]
        public string Email { get; set; }

        public string ComputerDevice { get; set; }

        [Required(ErrorMessage ="Please Enter your phone Number")]
        public string Phone { get; set; }
       
    }
}
