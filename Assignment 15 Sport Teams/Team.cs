using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sport_Teams
{
    class Team
    {
        protected string Name;
        protected int GamesPlayed;
        protected int GamesWon;
        protected int GamesLost;

        public double GetWinPercent()
        {
            double winpercent = (double) GamesWon / GamesPlayed;
            return winpercent;
        }

        public string TeamStats()
        {
            return "Games Played: " + GamesPlayed + "  Games Won: "+ GamesWon + "  Games Lost" + GamesLost;
        }


        public void AddGame(string result)
        {
            if (result == "win") 
            { 
                GamesWon++; 
            }
            else if (result == "lose") 
            {
                GamesLost++;
            }
            GamesPlayed++;
        }
        

    }
}
