using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpartanClash.Models;

namespace SpartanClash.ViewModels
{
    public class Leaderboard
    {
        public List<Leaderboardtem> leaderboardItems;

        public Leaderboard()
        {
            using (var db = new clashdbEntities())
            {
                List<t_companies> rankedCompanies = db.t_companies.Where(x => x.rank > 0).OrderBy(x => x.rank).ToList();

                leaderboardItems = new List<Leaderboardtem> (rankedCompanies.Count);

                foreach (t_companies company in rankedCompanies)
                {
                    leaderboardItems.Add(new Leaderboardtem(company));
                }
            }
        }

    }
}