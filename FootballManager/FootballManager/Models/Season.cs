using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballManager.Models
{
    public class Season
    {
        public int ID { get; set; }
        [Required]
        public DateTime YearS { get; set; }
   
        public virtual ICollection<Championship> Championship { get; set; }
        public virtual ICollection<Fixture> Fixture { get; set; }
    }
}