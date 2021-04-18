using System.Linq;

namespace TicTacToe.Rules
{
    public class FirstDiagonalRule : IGameOverRule
    {
        public bool IsGameOver(IReadOnlyBoard board)
            => board.NonEmptyFields
                .Where(field => field.X.Equals(field.Y))
                .Select(field => field.Sign)
                .Distinct()
                .Count() == 1;
    }
}