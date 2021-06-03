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
        private static bool isWinner(char[] b, char ch)
        {
            return ((b[1] == ch && b[2] == ch && b[3] == ch) ||
                (b[4] == ch && b[5] == ch && b[6] == ch) ||
                (b[7] == ch && b[8] == ch && b[9] == ch) ||
                (b[1] == ch && b[4] == ch && b[7] == ch) ||
                (b[2] == ch && b[5] == ch && b[8] == ch) ||
                (b[3] == ch && b[6] == ch && b[9] == ch) ||
                (b[1] == ch && b[5] == ch && b[9] == ch) ||
                (b[7] == ch && b[5] == ch && b[3] == ch));
        }
        private static int getComputerMove(char[] board, char computerLetter)
        {
            int winnigMove = getWinningMove(board, computerLetter);
            if (winnigMove != 0) return winnigMove;
            return 0;
        }

        private static int getWinningMove(char[] board, char letter)
        {
            for (int index = 0; index <= board.Length; index++)
            {
                char[] copyOfBoard = getCopyOfBoard(board);
                if (isFreeSpace(copyOfBoard, index))
                {
                    makeMove(copyOfBoard, index, letter);
                    if (isWinner(copyOfBoard, letter))
                        return index;
                }
            }
            return 0;
        }
        public static void makeMove(char[] board, int index, char letter)
        {
            bool spaceFree = isFreeSpace(board, index);
            if (spaceFree) board[index] = letter;
        }

        public static bool isFreeSpace(char[] board, int index)
        {
            return board[index] == ' ';
        }
        //GetUserMove
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
        private static char[] getCopyOfBoard(char[] board)
        {
            char[] boardCopy = new char[10];
            Array.Copy(board, boardCopy, board.Length);
            return boardCopy;
        }
        static void Main(string[] args)
        {

            char[] board = Tic_TacToc.createBoard();               
            Console.WriteLine(board);
            char choose = Tic_TacToc.chooseUserChar();
            Console.WriteLine("Your choice is " + choose);
            Tic_TacToc.showBoard(board);
            int userMove = getUserMove(board);
            makeMove(board, userMove, choose);
            Player player = getWhoStartFirst();
            Console.WriteLine("Check if Winner:" + isWinner(board, choose));
            Console.ReadKey();
        }
    }
}
