using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.SetPlayers(new HumanPlayer(), new AIPlayer());

            game.PlayRounds(5);
        }
    }
}
