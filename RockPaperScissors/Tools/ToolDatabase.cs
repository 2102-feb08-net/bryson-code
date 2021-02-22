using System.Collections.Generic;

namespace RockPaperScissors
{
    public class ToolDatabase
    {
        public List<IToolChoice> Tools = new List<IToolChoice>()
        {
            new Rock(),
            new Paper(),
            new Scissors(),
        };
    }
}