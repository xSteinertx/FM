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
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public List<Team> Teams { get; set; } //Aqui estava como string mas como são 2 teams achei melhor list (by Vitor)
        [Required]
        public int Score { get; set; }

        public virtual ICollection<Fixture> Fixture { get; set; }
        public virtual ICollection<Team> Team { get; set; }
    }
}