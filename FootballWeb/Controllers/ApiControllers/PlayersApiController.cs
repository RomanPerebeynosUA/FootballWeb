using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FootballWeb.ConnectionAPI;
using FootballWeb.ConnectionAPI.Repositories;
using FootballWeb.Data;
using FootballWeb.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FootballWeb.Controllers.ApiControllers
{
    public class PlayersApiController : Controller
    {
    

        private static HttpClient client = new HttpClient();

        PlayerApi playerApi = new PlayerApi();
        private readonly AppDBContext _context;
        
        public PlayersApiController(AppDBContext context )
        {
            _context = context;
            
        }

       public async Task<IActionResult> Index()
        {
            Connection.ConnectionToApi(client);
            
            string defolt = "players/47";
            Player player = new Player();
            player = await playerApi.GetEntityAsync(defolt, client);
            player.TeamId = 4;
            List<Player> players = new List<Player>();
            players.Add(player);
            return View(players.ToList());
        }
    }
}