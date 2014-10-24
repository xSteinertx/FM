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
        [Required]
        public string Logo { get; set; }
        [Required]
        [Display(Name="Foundation Date")]
        public DateTime DateFund { get; set; }
        public Boolean Coverage { get; set; }
        [Required]
        [Display(Name="Number of Teams")]
        public int NTeams { get; set; }
        [Required]
        [Display(Name="Total teams allowed")]
        public int NMaxTeams { get; set; }
        [Required]
        [Display(Name="Total Fixtures")]
        public int TFixture { get; set; }
        [Required]
        public string Owner { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
    }
}