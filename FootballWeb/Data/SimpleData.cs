using FootballWeb.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballWeb.Data
{
    public static class SimpleData
    {

        public static void Initialize(AppDBContext context)
        {
            
            if (!context.Players.Any())
            {
                
                context.Players.AddRange(
                    new Player
                    {
                       
                        FirstName = "Roman",
                        LastName = "Perebeynos",
                        Age = 20,
                        Nationality = "Ukrainian",
                        Role = "Attack",
                        
                        TeamId = 4
                    },
                    new Player
                    {
                        
                        FirstName = "Alex",
                        LastName = "Sandro",
                        Age = 25,
                        Nationality = "Turkish",
                        Role = "Defender",
                        TeamId = 4
                    },
                  new Player
                  {
                    
                      FirstName = "Leo",
                      LastName = "Messi",
                      Age = 20,
                      Nationality = "Argentina",
                      Role = "Attack",
                      TeamId = 4
                  }
                );
                context.SaveChanges();
            }
            if (!context.Championships.Any())
            {

                context.Championships.AddRange(
                    new Championship
                    {
                       // Id = 1,
                        Name = "EPL",
                        CountryName = "England",
                        NumberOfTeams = 20,


                    },
                        new Championship
                        {
                         //   Id = 2,
                            Name = "UPL",
                            CountryName = "Ukraine",
                            NumberOfTeams = 12,
                        }
                );
                context.SaveChanges();
            }
        }
    }
}
