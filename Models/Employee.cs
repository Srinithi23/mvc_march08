using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc_demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Username { get; set; }

        [ForeignKey("Username")]

        public LoginDetails Login { get; set; }


    }
}