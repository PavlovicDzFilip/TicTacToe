namespace TicTacToe
{
    public interface IReadOnlyBoard
    {
        Sign Get(Coord x, Coord y);
    }
}