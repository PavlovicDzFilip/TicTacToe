using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Board : IReadOnlyBoard
    {
        private readonly List<Field> _fields;

        public Board()
        {
            _fields = new List<Field>();
        }

        public void SetSignAt(Coord x, Coord y, Sign sign)
        {
            if (GetSignAt(x, y) != Sign.Empty)
            {
                throw new ArgumentException("Coordinate is already taken");
            }

            _fields.Add(new Field(x, y, sign));
        }

        public IReadOnlyCollection<Field> NonEmptyFields => _fields;

        public Sign GetSignAt(Coord x, Coord y)
            => GetFieldAt(x,y)?.Sign ?? Sign.Empty;

        private Field GetFieldAt(Coord x, Coord y)
            => _fields.FirstOrDefault(field => field.X.Equals(x) && field.Y.Equals(y));

    }
}