using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

// Model - a class with properties
namespace MVCDemo.Models
{
    public class PersonModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public bool Done { get; set; } 

        public string Name { get; set; }
        public string About { get; set; }

    }


}