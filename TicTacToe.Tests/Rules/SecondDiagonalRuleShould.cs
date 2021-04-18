using Shouldly;
using TicTacToe.Rules;
using Xunit;

namespace TicTacToe.Tests.Rules
{
    public class SecondDiagonalRuleShould
    {
        private readonly Board _board;
        private readonly IGameOverRule _rule;

        public SecondDiagonalRuleShould()
        {
            _board = new Board();
            _rule = new SecondDiagonalRule();
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
            _board.SetSignAt(0, 2, Sign.X);
            _board.SetSignAt(1, 1, Sign.X);
            _board.SetSignAt(2, 0, Sign.X);

            // Act
            var isGameOver = _rule.IsGameOver(_board);

            // Assert
            isGameOver.ShouldBeTrue();
        }
    }
}
