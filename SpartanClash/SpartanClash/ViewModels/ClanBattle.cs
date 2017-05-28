﻿using System;
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
        const string missingCompanyValue = "NOCOMPANYFOUND";
        const string printableMissingCompanyValue = "The World";

        public string primaryCompany { get; set; }
        public string allyHeader;
        public string enemyHeader; 

        public bool winner { get; set; }
        public int score { get; set; }
        public int enemeyScore { get; set; }

        private int team { get; set; }
        private string allyCompany { get; set; }
        private string enemyCompany1 { get; set; }
        private string enemyCompany2 { get; set; }


        public ClanBattle(string companyName, t_clashdevset match)
        {
            primaryCompany = companyName;
            DetermineTeam(match);
            DetermineTeamSpecificComponents(match);
            SetHeader(out allyHeader, primaryCompany, allyCompany);
            SetHeader(out enemyHeader, enemyCompany1, enemyCompany2);
            
        }

        private void SetHeader(out string header, string mainCompany, string secondaryCompany)
        {
            if(mainCompany == missingCompanyValue)
            {
                header = printableMissingCompanyValue;
            }
            else
            {
                if (secondaryCompany == missingCompanyValue)
                {
                    header = mainCompany;
                }
                else
                {
                    header = mainCompany + " & " + secondaryCompany;
                }
            }
        }

        private void DetermineTeam(t_clashdevset match)
        {
            if (primaryCompany == match.Team1_Company1 || primaryCompany == match.Team1_Company2)
                        {team = 1; }         else        { team = 2; }
        }

        private void DetermineTeamSpecificComponents(t_clashdevset match)
        {
            if(team == 1) //Company is on team 1
            {
                if(match.Team1_Rank == 1) { winner = true; } else { winner = false; } 
                score = (int)match.Team1_Score;
                enemeyScore = (int)match.Team2_Score;
                enemyCompany1 = match.Team2_Company1;
                enemyCompany2 = match.Team2_Company2;

                if (primaryCompany == match.Team1_Company1)
                {
                    allyCompany = match.Team1_Company2;
                }
                else
                {
                    allyCompany = match.Team1_Company2;
                }
            }
            else //Company is on team 2.
            {

                if (match.Team2_Rank == 1) { winner = true; } else { winner = false; }
                score = (int)match.Team2_Score;
                enemeyScore = (int)match.Team1_Score;

                enemyCompany1 = match.Team1_Company1;
                enemyCompany2 = match.Team1_Company2;

                if(primaryCompany == match.Team2_Company1)
                {
                    allyCompany = match.Team2_Company2;
                }
                else
                {
                    allyCompany = match.Team2_Company1;
                }

            }

        }

        

    }
}