using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballManager.Models
{
    public class Championship
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public int Year { get; set; }
        public string Logo { get; set; }
        [Required]
        public DateTime DateFund { get; set; }
        public Boolean Coverage { get; set; }
        public int NTeams { get; set; }
        public int NMaxTeams { get; set; }
        public int TFixture { get; set; }
        public string Owner { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
    }
}