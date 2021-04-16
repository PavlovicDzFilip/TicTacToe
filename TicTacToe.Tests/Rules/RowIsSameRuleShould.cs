using Shouldly;
using TicTacToe.Rules;
using Xunit;

namespace TicTacToe.Tests.Rules
{
    public class RowIsSameRuleShould
    {
        private readonly Board _board;
        private readonly IGameOverRule _rule;

        public RowIsSameRuleShould()
        {
            _board = new Board();
            _rule = new RowIsSameRule();
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
        public void BeTrueIfRowsAreSameAndNonEmpty(int rowIdx)
        {
            // Arrange
            var row = new Coord(rowIdx);
            _board.Set(row, 0, Sign.X);
            _board.Set(row, 1, Sign.X);
            _board.Set(row, 2, Sign.X);

            // Act
            var isGameOver = _rule.IsGameOver(_board);

            // Assert
            isGameOver.ShouldBeTrue();
        }
    }
}
