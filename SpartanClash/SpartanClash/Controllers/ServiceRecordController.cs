using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpartanClash.Models;

namespace SpartanClash.Controllers
{
    public class ServiceRecordController : Controller
    {
        // GET: ServiceRecord
        public ActionResult Index()
        {
            using (var db = new clashdbEntities())
            {
                List<t_clashdevset> allMatches = db.t_clashdevset.OrderBy(x => x.MatchId).ToList();
                return View(allMatches);
            }
        }

        public ActionResult Company(string companyName)
        {
            using(var db = new clashdbEntities())
            {
                List<t_clashdevset> companyMatches = db.t_clashdevset
                    .Where(
                        x => x.Team1_Company_1 == companyName 
                        || x.Team1_Company_2 == companyName 
                        || x.Team2_Company1 == companyName 
                        || x.Team2_Company2 == companyName
                    ).ToList();

                return View(companyMatches);
            }
        }
    }
}