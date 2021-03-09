using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_demo.Models
{
    public class LoginDetails
    {
        [Key]
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

    }
}