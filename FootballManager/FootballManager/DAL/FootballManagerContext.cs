using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FootballManager.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FootballManager.DAL
{
    public class FootballManagerContext : DbContext
    {
        public FootballManagerContext() : base("FootballManagerContext")
        {
        }

        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Championship> Championship { get; set; }
        public DbSet<Fixture> Fixture { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<User> User { get; set; }
    }
}