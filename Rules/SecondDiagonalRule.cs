namespace TicTacToe.Rules
{
    public class SecondDiagonalRule : IGameOverRule
    {
        public bool IsGameOver(Table table)
        {
            for (int i = 0; i < 3; i++)
            {
                if (table.Get(i, 2 - i) != table.Get(0, 2) || table.Get(0, 2) == Sign.Empty)
                {
                    return false;
                }
            }

            return true;
        }
    }
}