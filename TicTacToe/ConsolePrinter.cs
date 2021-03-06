using System;

namespace TicTacToe
{
    public class ConsolePrinter : ITicTacToePrinter
    {
        public void Print(IReadOnlyBoard board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board.GetSignAt(i, j));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}