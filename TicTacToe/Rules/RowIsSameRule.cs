using System.Linq;

namespace TicTacToe.Rules
{
    public class RowIsSameRule : IGameOverRule
    {
        public bool IsGameOver(IReadOnlyBoard board)
            => board.NonEmptyFields
                .GroupBy(field => field.X)
                .Any(group =>
                    @group.Count() == 3 &&
                    @group.Select(field => field.Sign).Distinct().Count() == 1);
    }
}