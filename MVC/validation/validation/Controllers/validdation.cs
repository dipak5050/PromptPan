using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using validation.Models;
namespace validation.Controllers
{
    public class validdation
    {
        [Required]
        public string name { get; set; }
       
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [Range(18,1000)]
        public int age { get; set; }
    }
}