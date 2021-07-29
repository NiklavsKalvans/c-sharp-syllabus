using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        static bool playing = true;
        static int turn = 0;

        private static void Main(string[] args)
        {
            Console.WriteLine("Make a move, by entering 2 separate digits. First one being the column(0-2), second one the row(0-2)");
            InitBoard();
            DisplayBoard();

            char player1Mark = 'X';
            char player2Mark = '0';

            while (playing)
            {
                if (turn % 2 == 0)
                {
                    Console.WriteLine("Player X's turn");
                }
                else
                {
                    Console.WriteLine("Player 0's turn");
                }
                Console.WriteLine("Make your move");
                int col1 = int.Parse(Console.ReadLine());
                int row1 = int.Parse(Console.ReadLine());
                if (board[col1, row1] == 'X' || board[col1, row1] == '0')
                {
                    Console.WriteLine("This place is already taken");
                }
                else
                {
                    if (turn % 2 == 0)
                    {
                        board[col1, row1] = player1Mark;
                        turn++;

                        DisplayBoard();
                        WinCondition();
                        Tie();
                    }
                    else
                    {
                        board[col1, row1] = player2Mark;
                        turn++;

                        DisplayBoard();
                        WinCondition();
                        Tie();
                    }
                }
                Console.ReadKey();
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        public static void Tie()
        {
            if (turn > 8)
            {
                playing = false;
                Console.WriteLine("The game is a tie!");
            }
        }

        public static void WinCondition()
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != ' '||
                board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != ' '||
                board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != ' '||
                board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != ' '||
                board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != ' '||
                board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != ' '||
                board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' '||
                board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
                {
                    playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("Congrats on winning player 0, better luck next time player X");
                    }
                    else
                    {
                        Console.WriteLine("Congrats on winning player X, better luck next time player 0");
                    }
                }
        }

    }
}
