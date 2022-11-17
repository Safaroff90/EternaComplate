using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        private List<Team> team = Data.Team;
        public IActionResult Index()
        {
            return View(team);
        }
    }
}
