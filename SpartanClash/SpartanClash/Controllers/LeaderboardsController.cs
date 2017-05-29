using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpartanClash.Models;
using SpartanClash.ViewModels;

namespace SpartanClash.Controllers
{
    public class LeaderboardsController : Controller
    {
        // GET: Leaderboards
        [HandleError]
        public ActionResult Index()
        {
            Leaderboard leaderboard = new Leaderboard();

            return View(leaderboard);
        }
    }
}