namespace TicTacToe.Rules
{
    public class AllFieldsTakenRule : IGameOverRule
    {
        public bool IsGameOver(IReadOnlyBoard board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.Get(i, j) == Sign.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}