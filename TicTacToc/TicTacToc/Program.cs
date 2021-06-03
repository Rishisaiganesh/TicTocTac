using System;

namespace TicTacToc
{
    class Program
    {
        static void Main(string[] args)
        {
            Tic_TacToc tic = new Tic_TacToc();         
            tic.createBoard();                      
            char usersChoice = tic.chooseUserChar();
            Console.WriteLine("Users choice is :" + usersChoice);

            Console.ReadKey();
        }
    }
}
