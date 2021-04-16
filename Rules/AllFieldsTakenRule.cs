namespace TicTacToe.Rules
{
    public class AllFieldsTakenRule : IGameOverRule
    {
        public bool IsGameOver(Table table)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (table.Get(i, j) == Sign.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}