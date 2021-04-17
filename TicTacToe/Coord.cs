using System;
using Ardalis.GuardClauses;

namespace TicTacToe
{
    public class Coord : IComparable<Coord>
    {
        private readonly int _value;

        public Coord(int value)
        {
            _value = Guard.Against.OutOfRange(value, nameof(value), 0, 2);
        }

        public static implicit operator int(Coord coord)
            => coord._value;

        public int CompareTo(Coord other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return _value.CompareTo(other._value);
        }
    }
}