using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sport_Teams
{
    class BasketballTeam : Team
    {
        private int Baskets;
        private int Blocks;
        private int Steals;

        public BasketballTeam(string name)
        {
            Name = name;
            GamesPlayed = 0;
            GamesWon = 0;
            GamesLost = 0;
            Baskets = 0;
            Blocks = 0;
            Steals = 0;
        }

        public double CalcAvgSteals()
        {
            double average = (double)Steals / GamesPlayed;
            return average;
        }

        public double CalcAvgBaskets()
        {
            double average = (double)Baskets / GamesPlayed;
            return average;
        }

        public double CalcAvgBlocks()
        {
            double average = (double)Blocks / GamesPlayed;
            return average;
        }

    }
}
