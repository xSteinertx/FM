using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballManager.Models
{
    public class Fixture
    {
        public int ID { get; set; }
        [Required]
        [Display(Name="Fixture")]
        public int NFixture { get; set; }
        [Required]
        [Display(Name="Start Date")]
        public DateTime DateB { get; set; }
        [Required]
        [Display(Name="End Date")]
        public DateTime DateE { get; set; }
        [Required]
        [Display(Name="Matches")]
        public List<Match> LMatches { get; set; }


        public virtual ICollection<Season> Season { get; set; }
        public virtual ICollection<Match> Match { get; set; }
    }
}