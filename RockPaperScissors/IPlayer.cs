namespace RockPaperScissors
{
    public interface IPlayer
    {
        string Name {get; }

        IToolChoice SelectedTool {get; }

        void SelectTool(ToolDatabase toolDatabase);
    }
}