using System;

namespace RockPaperScissors
{
    public class AIPlayer : IPlayer
    {
        public string Name => "Computer";

        public IToolChoice SelectedTool {get; private set;}

        public void SelectTool(ToolDatabase toolDatabase)
        {
            Random random = new Random();
            int toolIndex = random.Next(toolDatabase.Tools.Count);
            SelectedTool = toolDatabase.Tools[toolIndex];
        }
    }
}