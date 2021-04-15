namespace TicTacToe.Rules
{
    public class FirstDiagonalRule : IGameOverRule
    {
        public bool IsGameOver(Table table)
        {
            for (int i = 0; i < 3; i++)
            {
                if (table.Get(i, i) != table.Get(0, 0) || table.Get(0, 0) == ' ')
                {
                    return false;
                }
            }

            return true;
        }
    }
}