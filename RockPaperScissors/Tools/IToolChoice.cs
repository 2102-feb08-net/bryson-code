namespace RockPaperScissors
{
    public interface IToolChoice
    {
        string Name { get; }
    }

    public enum Tool
    {
        Rock,
        Paper,
        Scissors,
    }
}