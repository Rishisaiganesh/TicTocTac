﻿using System;
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

        /// <summary>
        /// Method to take user choice that its O or X
        /// </summary>
        /// <returns>returns an user selection</returns>
        public static char chooseUserChar()
        {
            Console.WriteLine("Enter your choice X or O :");
            char userSelection = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(userSelection);
        }

        /// <summary>
        /// Method to show an board 
        /// </summary>
        public static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("_________________");
            Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("_________________");
            Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9]);
        }

        /// <summary>
        /// Getting user move 
        /// </summary>
        /// <returns></returns>
        public static int getUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("What is Your next move(1-9)???");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, elements => elements == index) != 0 && isFreeSpace(board, index))
                    return index;
            }
        }
        public static bool isFreeSpace(char[] board, int index)
        {
            return board[index] == ' ';
        }
    }
}

