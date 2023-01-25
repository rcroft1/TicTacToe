using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic tac toe!");


            // initializing varaibles and arrays

            char winner = 'C';
            string[,] board = new string[3, 3];
            int k = 0;
            Board pb = new Board();

            // populating the board with spaces to start

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i, j] = "*";
                }
            }

            // while loop until the game is won or tied

            while (winner == 'C')
            {

                // users inputing their moves onto a 2D array using coordinates

                Console.WriteLine("\n");
                Console.WriteLine("Input the X coordinate of your move ranging from 0 to 2: ");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the Y coordinate of your move ranging from 0 to 2: ");
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                // determining if the move should be an X or an O

                if (k % 2 == 0)
                {
                    board[Y, X] = "X";
                }
                else
                {
                    board[Y, X] = "O";
                }

                //outputting the board

                pb.PrintBoard(board);

                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 3; j++)
                //    {
                //        Console.Write(board[i, j]);
                //    }
                //    Console.WriteLine("\n");
                //}



                k++;
                winner = pb.CheckWinner((board));
            }

            if (winner == 'X')
            {
                Console.WriteLine("Player X has won the game!");
            }
            if(winner == 'O')
            {
                Console.WriteLine("Player O has won the game!");
            }
            if(winner == 'T')
            {
                Console.WriteLine("The game was a tie!");
            }

        }
    }
}
