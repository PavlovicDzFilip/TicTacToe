using Shouldly;
using TicTacToe.Rules;
using Xunit;

namespace TicTacToe.Tests.Rules
{
    public class AllFieldsTakenRuleShould
    {
        private readonly Board _board;
        private readonly IGameOverRule _rule;

        public AllFieldsTakenRuleShould()
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
        public void BeTrueIfAllFieldsTaken()
        {
            // Arrange
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _board.SetSignAt(i, j, Sign.X);
                }
            }

            // Act
            var isGameOver = _rule.IsGameOver(_board);

            // Assert
            isGameOver.ShouldBeTrue();
        }
    }
}
