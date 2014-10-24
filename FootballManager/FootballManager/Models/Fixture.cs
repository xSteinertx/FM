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
        public int NFixture { get; set; }
        [Required]
        public DateTime DateB { get; set; }
        public DateTime DateE { get; set; }
        public List<Match> LMatches { get; set; }


        public virtual ICollection<Season> Season { get; set; }
        public virtual ICollection<Match> Match { get; set; }
    }
}