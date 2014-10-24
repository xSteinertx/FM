using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballManager.Models
{
    public class Administrator
    {
        public int ID { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}