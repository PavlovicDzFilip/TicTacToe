using System.Collections.Generic;

namespace TicTacToe
{
    public interface IReadOnlyBoard
    {
        IReadOnlyCollection<Field> NonEmptyFields { get; }
        Sign GetSignAt(Coord x, Coord y);

    }
}