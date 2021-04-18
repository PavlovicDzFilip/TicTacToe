namespace TicTacToe.Rules
{
    public class FirstDiagonalRule : IGameOverRule
    {
        public bool IsGameOver(IReadOnlyBoard board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board.Get(i, i) != board.Get(0, 0) || board.Get(0, 0) == Sign.Empty)
                {
                    return false;
                }
            }

            return true;
        }
    }
}