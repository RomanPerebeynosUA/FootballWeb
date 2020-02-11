using FootballWeb.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballWeb.Data
{
    public class AppDBContext :DbContext 
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Result> Results { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){
            Database.EnsureCreated();
        }
        
    }
}
