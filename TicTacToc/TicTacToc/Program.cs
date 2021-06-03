using System;

namespace TicTacToc
{
    class Program
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum Player { USER, COMPUTER };

        private static Player getWhoStartFirst()
        {
            int toss = getOneFromRandomChoice(2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;
        }
        private static int getOneFromRandomChoice(int choices)
        {
            Random objRandom = new Random();
            return (int)(objRandom.Next() * 10) % choices;
        }
        static void Main(string[] args)
        {

            char[] board = Tic_TacToc.createBoard();               
            Console.WriteLine(board);
            char choose = Tic_TacToc.chooseUserChar();
            Console.WriteLine("Your choice is " + choose);
            Tic_TacToc.showBoard(board);
            int userMove = Tic_TacToc.getUserMove(board);
            Tic_TacToc.makeMove(board, userMove, choose);
            Player player = getWhoStartFirst();
            Console.ReadKey();
        }
    }
}
