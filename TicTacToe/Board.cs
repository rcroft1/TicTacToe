using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public int PrintBoard (string[,] board)
        {
            for (int i = 0; i < 3; i += 1)
            {
                //makes and populates the board
                Console.WriteLine(" {0} | {1} | {2}", board[i,i], board[i + 1,i], board[i + 2,i]);
                if (i < 2)
                {
                    Console.WriteLine("---|---|---");
                }
            }
        }


        public int CheckWinner (string[,] board)
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (board[0,0] == board[1,0] && board[1,0] == board[2,0])
            {
                if (board[0,0] == "O") {
                    return 'O'; 
                }
                else {
                    return 'X';
                }
                
            }
            //Winning Condition For Second Row
            else if (board[4] == board[5] && board[5] == board[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (board[3] == board[6] && board[6] == board[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (board[1] == board[5] && board[5] == board[9])
            {
                return 1;
            }
            else if (board[3] == board[5] && board[5] == board[7])
            {
                return 1;
            }
            #endregion
        }
    }
}
