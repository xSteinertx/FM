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

        [Required]
        public int Age { get; set; }

        [Required]
        public string Country { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [Required]
        [Display(Name = "E-mail Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual Administrator Administrator { get; set; }
    }
}