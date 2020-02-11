using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballWeb.Models.Entity
{
    public class Championship : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public int NumberOfTeams { get; set; }
        public string Description { get; set; }

        public List<Team> Teams { get; set; }

        public List<Result> Results { get; set; }
    }
}
