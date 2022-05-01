//written by Zak Law
// Date: 4/30/2022

//This is a two player tic tac toe game.
using System;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(

                "Welcome to Tic Tac Toe!\n" +
                "Player 1 is X and Player 2 is O.\n" +
                "The first player to get 3 in a row wins.\n" +
                "Press any key to continue.");
            Console.ReadKey();
            Console.Clear();


            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var player_turn = "1";

            //This is the main game loop.
            do
            {
                //clear the screen
                Console.Clear();
                Console.WriteLine($"It is Player {player_turn}'s turn.\n");
                //print the board
                Board(arr);
                //get the player's move
                var user_input = GetUserInput();
                //update the board
                PlaceMarker(user_input, player_turn, arr);
                //check for a winner
                bool win = CheckWin(arr);
                if (win)
                {
                    Console.Clear();
                    Board(arr);
                    Console.WriteLine($"Player {player_turn} has won!");
                    Console.ReadKey();
                    break;
                }
                //check for a tie
                bool draw = CheckFull(arr);
                if (draw == true)
                {
                    Console.Clear();
                    Board(arr);
                    Console.WriteLine("The game is a draw!");
                    Console.ReadKey();
                    break;
                }
                //switch players
                player_turn = next_turn(player_turn);

                
            }while(true);

            
        }
        
        //this function prints the board
        private static void Board(char[] arr)
        {
            Console.WriteLine("{0}|{1}|{2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("-+-+-");
            Console.WriteLine("{0}|{1}|{2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("-+-+-");
            Console.WriteLine("{0}|{1}|{2}", arr[7], arr[8], arr[9]);
        }

        //get the user input to later place on the board
        public static string GetUserInput()
        {
        do
        {
        Console.WriteLine("Please enter a number between 1 and 9 to place your marker.");
        var input = Console.ReadLine();
        if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9")
        {
        return input;
        }
        else
        {
        Console.WriteLine("Invalid input. Please try again.");
        Console.ReadKey();
        Console.Clear();
        continue;
        }
        } while (true);
        }

        //update the board with the user's input
        public static void PlaceMarker(string input, string player_turn, char[] arr)
        {
        if (player_turn == "1")
        {
        arr[int.Parse(input)] = 'X';
        }
        else
        {
        arr[int.Parse(input)] = 'O';
        }
        }
            
        
        //change the player's turn
        public static string next_turn(string player_turn)
        {
            if (player_turn == "1")
            {
                return "2";
            }
            else
            {
                return "1";
            }
        }


        //check win conditions
        public static bool CheckWin(char[] arr)
        {
            //check horizontal
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                Console.WriteLine($"Player {arr[1]} wins!");
                return true;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                Console.WriteLine($"Player {arr[4]} wins!");
                return true;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                Console.WriteLine($"Player {arr[7]} wins!");
                return true;
            }
            //check vertical
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                Console.WriteLine($"Player {arr[1]} wins!");
                return true;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                Console.WriteLine($"Player {arr[2]} wins!");
                return true;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                Console.WriteLine($"Player {arr[3]} wins!");
                return true;
            }
            //check diagonal
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                Console.WriteLine($"Player {arr[1]} wins!");
                return true;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                Console.WriteLine($"Player {arr[3]} wins!");
                return true;
            }
            else
            {
                return false;
            }
        }

        //check if the board is full
        public static bool CheckFull(char[] arr)
        {
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] == 'X' || arr[i] == 'O')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
