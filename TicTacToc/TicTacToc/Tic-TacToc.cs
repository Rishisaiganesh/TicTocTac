using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToc
{
    class Tic_TacToc
    {
        public static char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(board[i] = '_');
            }
            return board;
        }

     
        public static char chooseUserChar()
        {
            Console.WriteLine("Enter your choice X or O :");
            char userSelection = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(userSelection);
        }

       
        public static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("_________________");
            Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("_________________");
            Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9]);
        }
    }
}