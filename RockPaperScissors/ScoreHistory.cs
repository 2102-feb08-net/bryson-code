using System.Collections.Generic;

namespace RockPaperScissors
{
    public class RoundHistory
    {
        private Dictionary<IPlayer, int> playerWins = new Dictionary<IPlayer, int>();

        public void AddPlayer(IPlayer player)
        {
            playerWins.Add(player, 0);
        }

        public void AddWin(IPlayer player)
        {
            if(!playerWins.ContainsKey(player))
                playerWins[player]++;
            else
                throw new System.AccessViolationException("Player must be added before giving them a win.");
        }
    }
}