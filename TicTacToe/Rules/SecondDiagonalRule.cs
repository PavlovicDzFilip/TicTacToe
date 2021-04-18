using System.Linq;

namespace TicTacToe.Rules
{
    public class SecondDiagonalRule : IGameOverRule
    {
        public bool IsGameOver(IReadOnlyBoard board)
            => board.NonEmptyFields
                .Where(field => field.X.Equals(2 - field.Y))
                .Select(field => field.Sign)
                .Distinct()
                .Count() == 1;
    }
}