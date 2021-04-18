namespace TicTacToe.Rules
{
    public class SecondDiagonalRule : IGameOverRule
    {
        public bool IsGameOver(IReadOnlyBoard board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board.Get(i, 2 - i) != board.Get(0, 2) || board.Get(0, 2) == Sign.Empty)
                {
                    return false;
                }
            }

            return true;
        }
    }
}