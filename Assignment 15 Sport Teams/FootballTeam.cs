using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sport_Teams
{
    class FootballTeam : Team
    {
        private int TotalGoals;
        private int RedCards;
        private int YellowCards;

        public FootballTeam(string name)
        {
            Name = name;
            GamesPlayed = 0;
            GamesWon = 0;
            GamesLost = 0;
            YellowCards = 0;
            RedCards = 0; 
        }

        public double CalcAvgRedCards()
        {
            double average = (double) RedCards / GamesPlayed;
            return average;
        }
        
        public double CalcAvgGoals()
        {
            double average = (double) TotalGoals / GamesPlayed;
            return average;
        }

        public void AddGoal()
        {
            TotalGoals++;
        }

        public void AddGame(string result, int goals, int redcards, int yellowcards)
        {
            if(result == "win")
            {
                GamesWon++;
            }
            else if(result == "lose")
            {
                GamesLost++;
            }
            TotalGoals = TotalGoals + goals;
            RedCards = RedCards + redcards;
            YellowCards = YellowCards + yellowcards;
        }
    }
}
