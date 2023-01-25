using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        //printing board
        public void PrintBoard(string[,] board)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine("\n");
            }
            }


        public char CheckWinner (string[,] board)
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if ((board[0,0] == board[1,0] && board[1,0] == board[2,0]) && (board[0,0] != "*"))
            {
                if (board[0,0] == "O")
                {
                    return 'O';
                }
                    
                else
                
                    return 'X';
                 
            }
            //Winning Condition For Second Row
            else if ((board[0,1] == board[1,1] && board[1,1] == board[2,1]) && (board[0, 1] != "*"))
            {
                if (board[0,1] == "O")
                {
                    return 'O';
                }

                else

                    return 'X';
            }
            //Winning Condition For Third Row
            else if ((board[0,2] == board[1,2] && board[1,2] == board[2,2]) && (board[0, 2] != "*"))
            {
                if (board[0,2] == "O")
                {
                    return 'O';
                }

                else

                    return 'X';
            }
            #endregion

            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if ((board[0,0] == board[0,1] && board[0,1] == board[0,2]) && (board[0, 0] != "*"))
            {
                if (board[0,0] == "O")
                {
                    return 'O';
                }

                else

                    return 'X';
            }
            //Winning Condition For Second Column
            else if ((board[1,0] == board[1,1] && board[1,1] == board[1,2]) && (board[1, 0] != "*"))
            {
                if (board[1,0] == "O")
                {
                    return 'O';
                }

                else

                    return 'X';
            }
            //Winning Condition For Third Column
            else if ((board[2,0] == board[2,1] && board[2,1] == board[2,2]) && (board[2, 0] != "*"))
            {
                if (board[2,0] == "O")
                {
                    return 'O';
                }

                else

                    return 'X';
            }
            #endregion
            // *region Diagonal Winning Condition*
            else if ((board[0,0] == board[1,1] && board[1,1] == board[2,2]) && (board[0, 0] != "*"))
            {
                if (board[0,0] == "O")
                {
                    return 'O';
                }

                else

                    return 'X';
            }
            else if ((board[2,0] == board[1,1] && board[1,1] == board[0,2]) && (board[2, 0] != "*"))
            {
                if (board[2,0] == "O")
                {
                    return 'O';
                }

                else

                    return 'X';
            }
            
            // Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (board[0,0] != "*" &&  board[1,0] != "*" && board[2,0] != "*" && board[0,1] != "*" && board[1,1] != "*" && board[2,1] != "*" && board[0,2] != "*" && board[1,2] != "*" && board[2,2] != "*")
            {
                return 'T';
            }
            
            else
            {
                return 'C';
            }
        }
    }
}
