using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpartanClash.Models;

namespace SpartanClash.ViewModels
{
    public class Leaderboardtem
    {
        public int rank { get; }
        public string companyName { get; }
        public string winPercent { get; }
        public int wins { get; }
        public int losses { get; }
        public int totalMatches { get; }

        public Leaderboardtem(t_companies rawItem)
        {
            rank = rawItem.rank;

            companyName = rawItem.company;

            winPercent = ConvertWinPercent(rawItem.win_percent);
            
            if(rawItem.wins == null)    {wins = 0;}
            else                        {wins = (int)rawItem.wins; }

            if (rawItem.losses == null) { losses = 0; }
            else { losses = (int)rawItem.losses; }

            if (rawItem.total_matches == null)  {totalMatches = 0;}
            else                                { totalMatches = (int)rawItem.total_matches;}

        }

        private string ConvertWinPercent(double? rawWinPercent)
        {
            if(rawWinPercent == null || rawWinPercent == 0)
            {
                return "0%";
            }
            else
            {
                return Math.Round((double)rawWinPercent, 2).ToString() + "%";
            }
        }

    }
}