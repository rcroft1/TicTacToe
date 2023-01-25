using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic tac toe!");

            bool winner = false;
            // List<int> moveCoordinates = new System.Collections.Generic.List<int>() { 0, 0 };
            // int[] moveCoordinates = new int[2];
            string[,] board = new string[3, 3];
            int k = 0;

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i, j] = "*";
                }
            }

            while (winner == false)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Input the X coordinate of your move ranging from 0 to 2: ");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the Y coordinate of your move ranging from 0 to 2: ");
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");


                if (k % 2 == 0)
                {
                    board[Y, X] = "X";
                }
                else
                {
                    board[Y, X] = "O";
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(board[i, j]);
                    }
                    Console.WriteLine("\n");
                }

                k++;
            }

            if (k % 2 == 1)
            {
                Console.WriteLine("Player X has won the game!");
            }
            else
            {
                Console.WriteLine("Player O has won the game!");
            }
            
            
        }
    }
}
