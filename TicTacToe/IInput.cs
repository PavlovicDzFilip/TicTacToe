namespace TicTacToe
{
    public interface IInput
    {
        (Coord X, Coord Y) GetInput();
    }
}