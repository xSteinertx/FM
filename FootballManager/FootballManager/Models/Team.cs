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
        public string Logo { get; set; }
        public DateTime DateFund { get; set; }
        [Required]
        public string Country { get; set; }
        public string City { get; set; }
        public string Colours { get; set; }

        public virtual ICollection<Season> Season { get; set; }
        public virtual ICollection<Match> Match { get; set; }
    }
}