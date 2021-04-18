using Shouldly;
using TicTacToe.Rules;
using Xunit;

namespace TicTacToe.Tests.Rules
{
    public class ColumnIsSameRuleShould
    {
        private readonly Board _board;
        private readonly IGameOverRule _rule;

        public ColumnIsSameRuleShould()
        {
            _board = new Board();
            _rule = new ColumnIsSameRule();
        }

        [Fact]
        public void BeFalseOnEmptyBoard()
        {
            // Arrange
            // Act
            var isGameOver = _rule.IsGameOver(_board);

            // Assert
            isGameOver.ShouldBeFalse();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void BeTrueIfRowsAreSameAndNonEmpty(int colIdx)
        {
            // Arrange
            var col = new Coord(colIdx);
            _board.SetSignAt(0, col, Sign.X);
            _board.SetSignAt(1, col, Sign.X);
            _board.SetSignAt(2, col, Sign.X);

            // Act
            var isGameOver = _rule.IsGameOver(_board);

            // Assert
            isGameOver.ShouldBeTrue();
        }
    }
}
