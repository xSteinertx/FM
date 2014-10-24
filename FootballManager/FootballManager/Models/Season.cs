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
        [Display(Name = "Season")]
        [RegularExpression("^[1-2]{1}[0-9]{3}-[1-2]{1}[0-9]{3}$",
            ErrorMessage="The correct format is yyyy-yyyy")]
        public string SeasonT { get; set; }

        public virtual ICollection<Championship> Championship { get; set; }

        public virtual ICollection<Fixture> Fixture { get; set; }
    }
}