namespace TicTacToe
{
    public class Table
    {
        private readonly char[][] _table;
        public Table()
        {
            _table = GetTable();
        }

        private static char[][] GetTable()
        {
            char[][] table = new char[3][];
            for (int i = 0; i < 3; i++)
            {
                table[i] = new char[3];
                for (int j = 0; j < 3; j++)
                {
                    table[i][j] = ' ';
                }
            }

            return table;
        }

        public void Set(int x, int y, char sign)
        {
            _table[x][y] = sign;
        }

        public char Get(int x, int y)
            => _table[x][y];
    }
}