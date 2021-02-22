using System;

namespace RockPaperScissors
{
    public class HumanPlayer : IPlayer
    {
        public string Name {get;}

        public IToolChoice SelectedTool {get; private set;}

        public HumanPlayer()
        {
            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();
        }

        public void SelectTool(ToolDatabase toolDatabase)
        {
            string inputChoice;
            IToolChoice matchedTool;
            do
            {
                Console.WriteLine("Do you want to play Rock (R), Paper (P), or Scissors (S)?");
                inputChoice = Console.ReadLine();
            
            }
            while (IsChoiceInvalid(inputChoice, toolDatabase, out matchedTool));
            SelectedTool = matchedTool;
        }

        bool IsChoiceInvalid(string choice, ToolDatabase toolDatabase, out IToolChoice matchedTool)
        {
            foreach (var tool in toolDatabase.Tools)
            {
                if(choice.ToLower() == tool.Name.ToLower(), StringComparer.InvariantCultureIgnoreCase))
                {
                    matchedTool = tool;
                    return true;
                }
            }
        
            Console.WriteLine("Invalid Response. Please choose a valid letter response.");
            matchedTool = null;
            return false;
        }
    }
}