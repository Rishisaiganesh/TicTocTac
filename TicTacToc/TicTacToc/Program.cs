﻿using System;

namespace TicTacToc
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] board = Tic_TacToc .createBoard();                 
            Console.WriteLine(board);
            char choose = Tic_TacToc.chooseUserChar();
            Console.WriteLine("Your choice is " + choose);
            Tic_TacToc.showBoard(board);

            Console.ReadKey();
        }
    }
}
