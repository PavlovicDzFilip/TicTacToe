using System;
using TicTacToe.Rules;

namespace TicTacToe
{
    public class TicTacToe
    {
        private readonly Board _board;
        private Sign _nextSign;
        private readonly IGameOverRule _gameOverRule;
        public bool IsGameOver { get; private set; }

        public TicTacToe()
        {
            _board = new Board();
            _gameOverRule = new GameOverRule();
            _nextSign = Sign.X;
        }

        public void Input(Coord x, Coord y)
        {
            if (IsGameOver)
            {
                throw new InvalidOperationException("Game is already completed");
            }

            _board.Set(x, y, _nextSign);
            ToggleNextSign();
            IsGameOver = _gameOverRule.IsGameOver(_board);
        }

        private void ToggleNextSign()
            => _nextSign = _nextSign == Sign.X ? Sign.O : Sign.X;

        public void Print(ITicTacToePrinter printer)
            => printer.Print(_board);
    }
}