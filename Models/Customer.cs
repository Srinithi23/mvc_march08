using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_demo.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Id can not be empty")]
        public string Id { get; set; }
          

        [Required(ErrorMessage ="Name can not be empty")]
        [RegularExpression("[A-Za-z]*",ErrorMessage ="Invalid entry for name")]
        public string Name { get; set; }


        [Required(ErrorMessage ="Invalid phone number")]
        public string Phone { get; set; }
    }
}