namespace RockPaperScissors
{
    public class Round
    {
        IPlayer _player1, _player2;

        public Round(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void SelectTools(ToolDatabase toolDatabase)
        {
            _player1.SelectTool(toolDatabase);
            _player2.SelectTool(toolDatabase);
        }

        public bool GetVictor(out IPlayer winner, out IPlayer loser)
        {
            bool isTie;
            ToolComparerer comparer = new ToolComparerer();
            winner = comparer.CompareTools(_player1, _player2);

            if(winner == null)
            {   
                loser = null;
                return isTie = true;
            }

            else
            {
                loser = (winner  == _player1) ? _player2 : _player1;

                return isTie = false;
            }
        }
    }
}