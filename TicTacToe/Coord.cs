using System;
using System.Diagnostics;
using Ardalis.GuardClauses;

namespace TicTacToe
{
    [DebuggerDisplay("{_value}")]
    public class Coord : IComparable<Coord>, IEquatable<Coord>
    {
        private readonly int _value;

        public Coord(int value)
        {
            _value = Guard.Against.OutOfRange(value, nameof(value), 0, 2);
        }

        public static implicit operator int(Coord coord)
            => coord._value;

        public static implicit operator Coord(int value)
            => new Coord(value);

        public int CompareTo(Coord other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return _value.CompareTo(other._value);
        }

        public bool Equals(Coord other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Coord)obj);
        }

        public override int GetHashCode()
        {
            return _value;
        }
    }
}