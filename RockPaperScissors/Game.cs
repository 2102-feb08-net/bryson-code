using System;

namespace RockPaperScissors
{
    public class Game
    {
        IPlayer _player1, _player2;

        public void SetPlayers(IPlayer player1, IPlayer player2)
        {
            if(player1 == null || player2 == null)
                throw new System.Exception("Null players are not allowed.");

            _player1 = player1;
            _player2 = player2;
        }

        public void PlayRounds(int roundCount)
        {
            for(int i = 0; i < roundCount; i++)
            {
                Round round = new Round(_player1, _player2);
                Console.WriteLine($"Round {i+1}: {_player1} versus {_player2}");
                round.SelectTools();
                bool isTie = round.GetVictor(out IPlayer winner, out IPlayer loser);
                if(isTie)
                    Console.WriteLine($"Both Players Tied. {_player1.Name} played {_player1.SelectedTool.Name} and {_player2.Name} played {_player2.SelectedTool.Name}.");
                else
                {

                    Console.WriteLine($"{winner.Name} wins using {winner.SelectedTool.Name} against {loser.Name}'s choice of {loser.SelectedTool.Name}");


                }
            }
        }
    }
}