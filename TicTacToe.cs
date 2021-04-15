using System;
using System.Linq;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Table _table;
        private bool _isXNext;
        public bool IsGameOver { get; private set; }

        public TicTacToe()
        {
            _table = new Table();
            _isXNext = true;
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
            _table.Set(inputX, inputY, nextSign);
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
                var rowIsSame = true;
                for (int j = 0; j < 3; j++)
                {
                    if (_table.Get(i, j) != _table.Get(i, 0) || _table.Get(i, 0) == ' ')
                    {
                        rowIsSame = false;
                    }
                }
                gameOver = rowIsSame;

                var columnIsSame = true;
                for (int j = 1; j < 3; j++)
                {
                    if (_table.Get(j, i) != _table.Get(j - 1, i) || _table.Get(0, i) == ' ')
                    {
                        columnIsSame = false;
                    }
                }

                gameOver = gameOver || columnIsSame;

                if (_table.Get(i, i) != _table.Get(0, 0) || _table.Get(0, 0) == ' ')
                {
                    firstDiagonal = false;
                }

                if (_table.Get(i, 2 - i) != _table.Get(0, 2) || _table.Get(0, 2) == ' ')
                {
                    secondDiagonal = false;
                }

                for (int j = 0; allFieldsTaken && j < 3; j++)
                {
                    allFieldsTaken = _table.Get(i, j) != ' ';
                }
            }

            gameOver = gameOver || firstDiagonal || secondDiagonal || allFieldsTaken;

            IsGameOver = gameOver;
        }

        public void Print(ITicTacToePrinter printer) 
            => printer.Print(_table);
    }
}