using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Model
{
   
    public class UserDto:BaseDto
    {

        [Required]
        public string  UserName { get; set; }

        public string M_sex { get; set; }

        [Required]
        public string Account { get; set; }

    }
}
