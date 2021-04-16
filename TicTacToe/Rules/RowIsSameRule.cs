namespace TicTacToe.Rules
{
    public class RowIsSameRule : IGameOverRule
    {
        public bool IsGameOver(Board board)
        {
            for (int i = 0; i < 3; i++)
            {
                var rowIsSame = true;
                for (int j = 0; j < 3; j++)
                {
                    if (board.Get(i, j) != board.Get(i, 0) || board.Get(i, 0) == Sign.Empty)
                    {
                        rowIsSame = false;
                        break;
                    }
                }

                if (rowIsSame)
                {
                    return true;
                }
            }

            return false;
        }
    }
}