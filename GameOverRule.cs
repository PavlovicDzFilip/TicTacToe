namespace TicTacToe
{
    public class GameOverRule : IGameOverRule
    {
        public bool IsGameOver(Table table)
        {
            var gameOver = false;

            var firstDiagonal = true;
            var secondDiagonal = true;
            var allFieldsTaken = true;

            for (int i = 0; i < 3 && !gameOver; i++)
            {
                var rowIsSame = true;
                for (int j = 0; j < 3; j++)
                {
                    if (table.Get(i, j) != table.Get(i, 0) || table.Get(i, 0) == ' ')
                    {
                        rowIsSame = false;
                    }
                }
                gameOver = rowIsSame;

                var columnIsSame = true;
                for (int j = 1; j < 3; j++)
                {
                    if (table.Get(j, i) != table.Get(j - 1, i) || table.Get(0, i) == ' ')
                    {
                        columnIsSame = false;
                    }
                }

                gameOver = gameOver || columnIsSame;

                if (table.Get(i, i) != table.Get(0, 0) || table.Get(0, 0) == ' ')
                {
                    firstDiagonal = false;
                }

                if (table.Get(i, 2 - i) != table.Get(0, 2) || table.Get(0, 2) == ' ')
                {
                    secondDiagonal = false;
                }

                for (int j = 0; allFieldsTaken && j < 3; j++)
                {
                    allFieldsTaken = table.Get(i, j) != ' ';
                }
            }

            gameOver = gameOver || firstDiagonal || secondDiagonal || allFieldsTaken;

            return gameOver;
        }
    }
}