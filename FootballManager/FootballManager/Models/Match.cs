using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootballManager.Models
{
    public class Match
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]

        public DateTime Time { get; set; }

        [Required]
        [Display(Name = "Teams")]
        public List<Team> Teams { get; set; } //Aqui estava como string mas como são 2 teams achei melhor list (by Vitor)

        [Display(Name = "Score")]
        [RegularExpression("^[1-2]?[0-9]-[1-2]?[0-9]$",
            ErrorMessage = "The correct format is e.g. 2-1")]
        public string Score { get; set; }

        public virtual ICollection<Fixture> Fixture { get; set; }
        public virtual ICollection<Team> Team { get; set; }
    }
}