using System.Diagnostics;

namespace TicTacToe
{
    [DebuggerDisplay("{X},{Y}={Sign}")]
    public class Field
    {
        public Coord X { get; }
        public Coord Y { get; }
        public Sign Sign { get; }

        public Field(Coord x, Coord y, Sign sign)
        {
            X = x;
            Y = y;
            Sign = sign;
        }
    }
}