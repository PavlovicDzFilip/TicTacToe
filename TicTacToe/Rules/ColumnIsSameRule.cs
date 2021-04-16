namespace TicTacToe.Rules
{
    public class ColumnIsSameRule : IGameOverRule
    {
        public bool IsGameOver(Board board)
        {
            for (int i = 0; i < 3; i++)
            {
                var collIsSame = true;
                for (int j = 1; j < 3; j++)
                {
                    if (board.Get(j, i) != board.Get(j - 1, i) || board.Get(0, i) == Sign.Empty)
                    {
                        collIsSame = false;
                        break;
                    }
                }

                if (collIsSame)
                {
                    return true;
                }
            }

            return false;
        }
    }
}