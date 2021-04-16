using Shouldly;
using TicTacToe.Rules;
using Xunit;

namespace TicTacToe.Tests.Rules
{
    public class FirstDiagonalRuleShould
    {
        private readonly Board _board;
        private readonly IGameOverRule _rule;

        public FirstDiagonalRuleShould()
        {
            _board = new Board();
            _rule = new FirstDiagonalRule();
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

        [Fact]
        public void BeTrueIfDiagonalIsSame()
        {
            // Arrange
            _board.Set(0, 0, Sign.X);
            _board.Set(1, 1, Sign.X);
            _board.Set(2, 2, Sign.X);

            // Act
            var isGameOver = _rule.IsGameOver(_board);

            // Assert
            isGameOver.ShouldBeTrue();
        }
    }
}
