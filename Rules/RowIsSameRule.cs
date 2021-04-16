namespace TicTacToe.Rules
{
    public class RowIsSameRule : IGameOverRule
    {
        public bool IsGameOver(Table table)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (table.Get(i, j) != table.Get(i, 0) || table.Get(i, 0) == Sign.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}