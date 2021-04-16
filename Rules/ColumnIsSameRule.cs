namespace TicTacToe.Rules
{
    public class ColumnIsSameRule : IGameOverRule
    {
        public bool IsGameOver(Table table)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    if (table.Get(j, i) != table.Get(j - 1, i) || table.Get(0, i) == Sign.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}