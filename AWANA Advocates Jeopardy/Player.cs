using System;
using System.Collections.Generic;
using System.Text;

namespace AWANA_Advocates_Jeopardy
{
    public class Player
    {
        public string playerName { get; set; }
        public int playerPoints { get; set; }

        public Player(string playerName)
        {
            this.playerName = playerName;
            playerPoints = 0;
        }
        public string FullInfo
        {
            get
            {
                return $"{ playerName} {playerPoints}";
            }
        }
    }
}
