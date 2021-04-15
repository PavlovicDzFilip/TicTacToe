﻿using System;

namespace TicTacToe
{
    public class ConsolePrinter : ITicTacToePrinter
    {
        public void Print(Table table)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(table.Get(i, j));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}