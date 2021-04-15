using System;
using System.Linq;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly char[][] _table;
        private bool _isXNext;
        public bool IsGameOver { get; private set; }

        public TicTacToe()
        {
            _table = GetTable();
            _isXNext = true;
        }

        private static char[][] GetTable()
        {
            char[][] table = new char[3][];
            for (int i = 0; i < 3; i++)
            {
                table[i] = new char[3];
                for (int j = 0; j < 3; j++)
                {
                    table[i][j] = ' ';
                }
            }

            return table;
        }

        public void Input(int inputX, int inputY)
        {
            if (IsGameOver)
            {
                throw new InvalidOperationException("Game is already completed");
            }

            var nextSign = _isXNext ? 'x' : 'o';
            _isXNext = !_isXNext;
            
            // assume input is always correct, and the field is not already taken
            _table[inputX][inputY] = nextSign;
            CheckIsGameOver();
        }

        private void CheckIsGameOver()
        {
            var gameOver = false;

            var firstDiagonal = true;
            var secondDiagonal = true;
            var allFieldsTaken = true;

            for (int i = 0; i < 3 && !gameOver; i++)
            {
                if (_table[i].All(x => x == _table[i][0]) && _table[i][0] != ' ')
                {
                    gameOver = true;
                }

                var columnIsSame = true;
                for (int j = 1; j < 3; j++)
                {
                    if (_table[j][i] != _table[j - 1][i] || _table[0][i] == ' ')
                    {
                        columnIsSame = false;
                    }
                }

                gameOver = gameOver || columnIsSame;

                if (_table[i][i] != _table[0][0] || _table[0][0] == ' ')
                {
                    firstDiagonal = false;
                }

                if (_table[i][2 - i] != _table[0][2] || _table[0][2] == ' ')
                {
                    secondDiagonal = false;
                }

                allFieldsTaken = allFieldsTaken && _table[i].All(x => x == ' ');
            }

            gameOver = gameOver || firstDiagonal || secondDiagonal || allFieldsTaken;

            IsGameOver = gameOver;
        }

        public void Print()
        {
            // print the table
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(_table[i][j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}