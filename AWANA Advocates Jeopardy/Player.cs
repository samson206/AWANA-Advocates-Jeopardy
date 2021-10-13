using System;
using System.Collections.Generic;
using System.Text;

namespace AWANA_Advocates_Jeopardy
{
    public class Player
    {
        string playerName;
        int playerPoints;

        public Player(string playerName)
        {
            this.playerName = playerName;
            playerPoints = 0;
        }

/*        public string ToString()
        {
            return playerName + " - " + playerPoints;
        }*/
    }
}
