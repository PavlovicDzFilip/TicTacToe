using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TicTacToe();
            while (!game.IsGameOver)
            {
                Console.WriteLine("Waiting for input");
                var input = Console.ReadLine();
                var inputX = int.Parse(input.Split(' ')[0]);
                var inputY = int.Parse(input.Split(' ')[1]);

                game.Input(inputX, inputY);
                game.Print(new ConsolePrinter());
            }

            Console.WriteLine("Game over!");
        }
    }
}
