using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballManager.Models
{
    public class Team
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Required]
        [Display(Name="Foundation Date")]
        [DataType(DataType.Date)]
        public DateTime DateFund { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Colours { get; set; }

        public virtual ICollection<Season> Season { get; set; }
        public virtual ICollection<Match> Match { get; set; }
    }
}