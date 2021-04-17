using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TicTacToe();
            var input = new ConsoleInput();
            var printer = new ConsolePrinter();
            while (!game.IsGameOver)
            {
                var coords = input.GetInput();
                game.Input(coords.X, coords.Y);
                game.Print(printer);
            }

            Console.WriteLine("Game over!");
        }
    }
}
