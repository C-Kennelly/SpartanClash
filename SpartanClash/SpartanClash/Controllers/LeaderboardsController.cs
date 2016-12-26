using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpartanClash.Controllers
{
    public class LeaderboardsController : Controller
    {
        // GET: Leaderboards
        public ActionResult Leaderboards()
        {
            return View();
        }
    }
}