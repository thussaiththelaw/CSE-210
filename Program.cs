// Tic Tac Toe game

using System;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("This is a two player game.");
            Console.WriteLine("Player 1 is X and Player 2 is O.");
            Console.WriteLine("The first player to get three in a row wins.");
            Console.WriteLine("Press any key to start.");
            Console.ReadKey();
            Console.Clear();
            string flavor_line = "-+-+-\n";
            string board_line_1 = "$|1|2|3|$\n";
            string board_line_2 = "|4|5|6|\n";
            string board_line_3 = "|7|8|9|\n";
            var player_turn = 1;

            //functions for the game
            //function to see if the space has already been used
            public int check_space(int space, int entry)
            {
                if entry <= 1 && entry >= 3
                {
                    
                }
            }

            do
            {
                Console.Write(board_line_1);
                Console.Write(flavor_line);
                Console.Write(board_line_2);
                Console.Write(flavor_line);
                Console.Write(board_line_3);
                Console.WriteLine("Player " + player_turn + "'s turn to choose a square (1-9): ");

            }
            while (true);
        }
    }
}