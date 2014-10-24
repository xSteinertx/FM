using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballManager.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }

        public virtual Administrator Administrator { get; set; }
    }
}