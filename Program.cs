using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
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

            bool gameOver = false;
            bool isXNext = true;
            while (!gameOver)
            {
                Console.WriteLine("Waiting for input");
                var input = Console.ReadLine();
                var inputX = int.Parse(input.Split(' ')[0]);
                var inputY = int.Parse(input.Split(' ')[1]);

                var nextSign = isXNext ? 'x' : 'o';
                isXNext = !isXNext;

                // assume input is always correct, and the field is not already taken
                table[inputX][inputY] = nextSign;

                // check is the game over
                var firstDiagonal = true;
                var secondDiagonal = true;

                // check rows
                for (int i = 0; i < 3 && !gameOver; i++)
                {
                    if (table[i].All(x => x == table[i][0]) && table[i][0] != ' ')
                    {
                        gameOver = true;
                    }

                    var columnIsSame = true;
                    for (int j = 1; j < 3; j++)
                    {
                        if (table[j][i] != table[j - 1][i] || table[0][i] == ' ')
                        {
                            columnIsSame = false;
                        }
                    }

                    gameOver = gameOver || columnIsSame;

                    if (table[i][i] != table[0][0] || table[0][0] == ' ')
                    {
                        firstDiagonal = false;
                    }

                    if (table[i][2 - i] != table[0][2] || table[0][2] == ' ')
                    {
                        secondDiagonal = false;
                    }
                }

                gameOver = gameOver || firstDiagonal || secondDiagonal;


                // print the table
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(table[i][j]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            Console.WriteLine("Game over!");
        }
    }
}
