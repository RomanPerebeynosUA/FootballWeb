using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballWeb.Models.Entity
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfzas { get; set; }
        public string Description { get; set; }

        public int ChampionshipId { get; set; }
        public Championship Champship { get; set; }

        public List<Player> Players { get; set; }
    }
}
