using System;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Table _table;
        private bool _isXNext;
        private readonly IGameOverRule _gameOverRule;
        public bool IsGameOver { get; private set; }

        public TicTacToe()
        {
            _table = new Table();
            _gameOverRule = new GameOverRule();
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

            IsGameOver = _gameOverRule.IsGameOver(_table);
        }

        public void Print(ITicTacToePrinter printer)
            => printer.Print(_table);
    }
}