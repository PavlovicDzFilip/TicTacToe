using System;

namespace TicTacToe
{
    public class ConsoleInput : IInput
    {
        public (Coord X, Coord Y) GetInput()
        {
            Console.WriteLine("Waiting for input");
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    var inputX = int.Parse(input.Split(' ')[0]);
                    var inputY = int.Parse(input.Split(' ')[1]);

                    return (new Coord(inputX), new Coord(inputY));
                }
                catch (Exception)
                {
                    Console.WriteLine("Error parsing input, Try again");
                }
            }


        }
    }
}