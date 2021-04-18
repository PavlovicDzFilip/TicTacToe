namespace TicTacToe.Rules
{
    public class AllFieldsTakenRule : IGameOverRule
    {
        public bool IsGameOver(IReadOnlyBoard board) 
            => board.NonEmptyFields.Count == 9;
    }
}