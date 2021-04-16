using System;

namespace TicTacToe
{
    public class Sign : IEquatable<Sign>
    {
        private readonly char _value;
        public static readonly Sign X = new Sign('X');
        public static readonly Sign O = new Sign('O');
        public static readonly Sign Empty = new Sign(' ');

        private Sign(char value)
        {
            _value = value;
        }

        public bool Equals(Sign other)
            => ReferenceEquals(other, this);

        public override bool Equals(object obj)
            => Equals(obj as Sign);

        public override int GetHashCode()
            => _value;

        public static bool operator ==(Sign a, Sign b)
            => ReferenceEquals(a, b);

        public static bool operator !=(Sign a, Sign b) 
            => !(a == b);

        public override string ToString()
            => _value.ToString();
    }
}