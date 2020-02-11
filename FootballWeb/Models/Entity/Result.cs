using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballWeb.Models.Entity
{
    public class Result
    {
        public int Id { get; set; }
        public string Season { get; set; }
        public int NumberOfgame { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public int ScoredGoals { get; set; }
        public int MissedGoals { get; set; }
        public int Points { get; set; }

        public int ChampshipID { get; set; }
        public Championship Champship { get; set; }
    }
}
