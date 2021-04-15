using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Rules
{
    public class GameOverRule : IGameOverRule
    {
        private readonly IReadOnlyCollection<IGameOverRule> _rules;
        public GameOverRule()
        {
            _rules = new List<IGameOverRule>()
            {
                new RowIsSameRule(),
                new ColumnIsSameRule(),
                new FirstDiagonalRule(),
                new SecondDiagonalRule(),
                new AllFieldsTakenRule()
            };
        }

        public bool IsGameOver(Table table)
            => _rules.Any(rule => rule.IsGameOver(table));
    }
}