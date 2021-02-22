using System.Collections.Generic;

namespace RockPaperScissors
{
    public class ToolComparerer
    {
        public List<WinCondition> winConditions = new List<WinCondition>()
        {
            new WinCondition(new Rock(), new Scissors()),
            new WinCondition(new Scissors(), new Paper()),
            new WinCondition(new Paper(), new Rock()),
        };

        public IPlayer CompareTools(IPlayer player1, IPlayer player2)
        {
            foreach(var condition in winConditions)
            {
                if(condition.WinningTool.Name == player1.SelectedTool.Name && condition.LosingTool.Name == player2.SelectedTool.Name)
                    return player1;
                else if(condition.LosingTool.Name == player1.SelectedTool.Name && condition.WinningTool.Name == player2.SelectedTool.Name)
                    return player2;
            }

            // It is a tie.
            return null;
        }

    }
}