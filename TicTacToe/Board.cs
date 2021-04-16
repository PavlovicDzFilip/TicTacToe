using System;

namespace TicTacToe
{
    public class Board
    {
        private readonly Sign[,] _board;
        public Board()
        {
            _board = GetTable();
        }

        private static Sign[,] GetTable()
        {
            var table = new Sign[,]
            {
                {Sign.Empty, Sign.Empty, Sign.Empty,},
                {Sign.Empty, Sign.Empty, Sign.Empty,},
                {Sign.Empty, Sign.Empty, Sign.Empty,},
            };

            return table;
        }

        public void Set(Coord x, Coord y, Sign sign)
        {
            if (_board[x, y] != Sign.Empty)
            {
                throw new ArgumentException("Coordinate is already taken");
            }

            _board[x, y] = sign;
        }

        public Sign Get(Coord x, Coord y)
            => _board[x, y];
    }
}