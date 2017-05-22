using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpartanClash.Models;

namespace SpartanClash.ViewModels
{
    /// <summary>
    /// Match results in a highly formatted fashion.
    /// </summary>
    public class ClanBattle
    {
        public string primaryCompany { get; set; }
        public string allyHeader { get; set; }
        public string enemyHeader { get; set; }

        private string ally { get; set; }
        private string enemyCompany1 { get; set; }
        private string enemyCompany2 { get; set; }


        public ClanBattle(string companyName, t_clashdevset match)
        {
            primaryCompany = companyName;
            //Build a clan battle from a match here
        }

        

    }
}