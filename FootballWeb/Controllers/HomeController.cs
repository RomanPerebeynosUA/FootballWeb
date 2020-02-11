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

namespace FootballWeb.Controllers
{
    public class HomeController : Controller
    {
        private AppDBContext db;


        public HomeController(AppDBContext context)
        {

            db = context;
        }

        public IActionResult Index()
        {
           // List<Team> tems = db.Teams.ToList();

            return View();
        }
        public IActionResult PlayerView()
        {
            List<Team> tems = db.Teams.ToList();

            return View(db.Players.ToList());
        }

      
    }
}
