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
            char_1 = ("1");
            char_2 = "2";
            char_3 = "3";
            char_4 = "4";
            char_5 = "5";
            char_6 = "6";
            char_7 = "7";
            char_8 = "8";
            char_9 = "9";
            string flavor_line = "-+-+-\n";
            string board_line_1 = "|" + char_1 + "|" + char_2 + "|" + char_3 + "|\n";
            string board_line_2 = "|" + char_4 + "|" + char_5 + "|" + char_6 + "|\n";
            string board_line_3 = "|" + char_7 + "|" + char_8 + "|" + char_9 + "|\n";
            var total_moves = 0;

            var player_turn = 1;

            //functions for the game
            //function to see if the space has already been used
            public int check_space(int entry)
            {
                if (entry <= 1 && entry >= 9)
                {
                    if (entry == 1)
                    {
                        if (char_1 == "X" || char_1 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    else if (entry == 2)
                    {
                        if (char_2 == "X" || char_2 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    else if (entry == 3)
                    {
                        if (char_3 == "X" || char_3 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    else if (entry == 4)
                    {
                        if (char_4 == "X" || char_4 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    else if (entry == 5)
                    {
                        if (char_5 == "X" || char_5 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    else if (entry == 6)
                    {
                        if (char_6 == "X" || char_6 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    else if (entry == 7)
                    {
                        if (char_7 == "X" || char_7 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    else if (entry == 8)
                    {
                        if (char_8 == "X" || char_8 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    else if (entry == 9)
                    {
                        if (char_9 == "X" || char_9 == "O")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Please enter a number between 1 and 9.");
                }
            }

            //change the board
            public int change_board(int entry, int player_turn)
            {
                if (player_turn == 1)
                {
                    if (entry == 1)
                    {
                        char_1 = "X";
                    }
                    else if (entry == 2)
                    {
                        char_2 = "X";
                    }
                    else if (entry == 3)
                    {
                        char_3 = "X";
                    }
                    else if (entry == 4)
                    {
                        char_4 = "X";
                    }
                    else if (entry == 5)
                    {
                        char_5 = "X";
                    }
                    else if (entry == 6)
                    {
                        char_6 = "X";
                    }
                    else if (entry == 7)
                    {
                        char_7 = "X";
                    }
                    else if (entry == 8)
                    {
                        char_8 = "X";
                    }
                    else if (entry == 9)
                    {
                        char_9 = "X";
                    }
                }
                else if (player_turn == 2)
                {
                    if (entry == 1)
                    {
                        char_1 = "O";
                    }
                    else if (entry == 2)
                    {
                        char_2 = "O";
                    }
                    else if (entry == 3)
                    {
                        char_3 = "O";
                    }
                    else if (entry == 4)
                    {
                        char_4 = "O";
                    }
                    else if (entry == 5)
                    {
                        char_5 = "O";
                    }
                    else if (entry == 6)
                    {
                        char_6 = "O";
                    }
                    else if (entry == 7)
                    {
                        char_7 = "O";
                    }
                    else if (entry == 8)
                    {
                        char_8 = "O";
                    }
                    else if (entry == 9)
                    {
                        char_9 = "O";
                    }
                }
            }

            //Check to see if there is a winner
            public int check_win()
            {
                if (char_1 == "X" && char_2 == "X" && char_3 == "X")
                {
                    return 1;
                }
                else if (char_4 == "X" && char_5 == "X" && char_6 == "X")
                {
                    return 1;
                }
                else if (char_7 == "X" && char_8 == "X" && char_9 == "X")
                {
                    return 1;
                }
                else if (char_1 == "X" && char_4 == "X" && char_7 == "X")
                {
                    return 1;
                }
                else if (char_2 == "X" && char_5 == "X" && char_8 == "X")
                {
                    return 1;
                }
                else if (char_3 == "X" && char_6 == "X" && char_9 == "X")
                {
                    return 1;
                }
                else if (char_1 == "X" && char_5 == "X" && char_9 == "X")
                {
                    return 1;
                }
                else if (char_3 == "X" && char_5 == "X" && char_7 == "X")
                {
                    return 1;
                }
                else if (char_1 == "O" && char_2 == "O" && char_3 == "O")
                {
                    return 2;
                }
                else if (char_4 == "O" && char_5 == "O" && char_6 == "O")
                {
                    return 2;
                }
                else if (char_7 == "O" && char_8 == "O" && char_9 == "O")
                {
                    return 2;
                }
                else if (char_1 == "O" && char_4 == "O" && char_7 == "O")
                {
                    return 2;
                }
                else if (char_2 == "O" && char_5 == "O" && char_8 == "O")
                {
                    return 2;
                }
                else if (char_3 == "O" && char_6 == "O" && char_9 == "O")
                {
                    return 2;
                }
                else if (char_1 == "O" && char_5 == "O" && char_9 == "O")
                {
                    return 2;
                }
                else if (char_3 == "O" && char_5 == "O" && char_7 == "O")
                {
                    return 2;
                }
                else
                {
                    return 0;
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
                var entry = Console.ReadLine();
                var entry_int = Convert.ToInt32(entry);
                check_space(entry_int);
                do
                {
                    Console.WriteLine("That space has already been taken.");
                    Console.WriteLine("Player " + player_turn + "'s turn to choose a square (1-9): ");
                    entry = Console.ReadLine();
                    int check_if_taken = check_space(entry_int);
                }
                while (check_if_taken == 1); ??????????????????????????????????????????????????????????????????????????????????????????????
                change_board(entry_int, player_turn);
                if (player_turn == 1)
                {
                    player_turn = 2;
                }
                else if (player_turn == 2)
                {
                    player_turn = 1;
                }

                if (total_moves <= 5)
                {
                    var win_check = check_win();
                if (win_check == 1)
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else if (win_check == 2)
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else if (win_check == 0 && total_moves == 9)
                {
                    Console.WriteLine("It's a tie!");
                }
                else
                {
                    continue;
                }
                }

            }
            while (true);
        }
    }
}