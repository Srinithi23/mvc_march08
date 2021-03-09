using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_demo.Models
{
    public class Address
    {
        public List<SelectListItem> mycities = new List<SelectListItem>();

        public Address()
        {
            mycities.Add(new SelectListItem() { Text = "Agra", Value = "AgraCity" });
            mycities.Add(new SelectListItem() { Text = "Chennai", Value = "ChennaiCity" });
            mycities.Add(new SelectListItem() { Text = "Delhi", Value = "DelhiCity" });
            mycities.Add(new SelectListItem() { Text = "Bangalore", Value = "BangaloreCity" });
        }
            public string SelectedCity { get; set; }
    }

    }
