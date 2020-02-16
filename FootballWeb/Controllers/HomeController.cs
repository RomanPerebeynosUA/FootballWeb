using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FootballWeb.Data;
using FootballWeb.Models.Entity;
using FootballWeb.Models;
using Microsoft.EntityFrameworkCore;
using FootballWeb.Repository.EntityFramework;
using FootballWeb.ConnectionAPI;
using System.Net.Http;

namespace FootballWeb.Controllers
{
    public class HomeController : Controller
    {
        private AppDBContext db;
        private static HttpClient client = new HttpClient();
   

        public HomeController(AppDBContext context)
        {

            db = context;

          
        }
        public async Task<IActionResult> Index()
        {
            Connection.ConnectionToApi(client);
            
            string defolt = "players/47";
            Player player = new Player();
         //   player = await con.GetPlayerAsync(defolt);
            player.TeamId = 4;
            List<Player> players = new List<Player>();
            players.Add(player);
            return View(players.ToList());
        }

        public IActionResult PlayerView()
        {
            List<Team> tems = db.Teams.ToList();

            return View(db.Players.ToList());
        }

      
    }
}
