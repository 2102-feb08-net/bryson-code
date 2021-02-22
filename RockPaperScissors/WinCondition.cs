namespace RockPaperScissors
{
    public class WinCondition
    {
        public IToolChoice WinningTool { get; }
        public IToolChoice LosingTool { get; }

        public WinCondition(IToolChoice winner, IToolChoice loser)
        {
            WinningTool = winner;
            LosingTool = loser;
        }
    }
}