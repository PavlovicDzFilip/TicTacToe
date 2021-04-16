namespace TicTacToe
{
    public class Table
    {
        private readonly Sign[][] _table;
        public Table()
        {
            _table = GetTable();
        }

        private static Sign[][] GetTable()
        {
            Sign[][] table = new Sign[3][];
            for (int i = 0; i < 3; i++)
            {
                table[i] = new Sign[3];
                for (int j = 0; j < 3; j++)
                {
                    table[i][j] = Sign.Empty;
                }
            }

            return table;
        }

        public void Set(Coord x, Coord y, Sign sign)
            => _table[x][y] = sign;

        public Sign Get(Coord x, Coord y)
            => _table[x][y];
    }
}