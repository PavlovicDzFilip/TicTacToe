namespace TicTacToe.Rules
{
    public interface IGameOverRule
    {
        bool IsGameOver(Table table);
    }
}