namespace TicTacToe.Rules
{
    public interface IGameOverRule
    {
        bool IsGameOver(IReadOnlyBoard board);
    }
}