using System.Globalization;

namespace TicTacToe
{
    internal class Program
    {
        public static void UpdateGameArray(String[,] gameArray, String position, String mark)
        {
            for (int i = 0; i < gameArray.GetLength(0); i++)
            {
                for (int j = 0; j < gameArray.GetLength(1); j++)
                {
                    if (gameArray[i,j] == position)
                    {
                        gameArray[i,j] = mark;
                        break;
                    }
                }
                Console.WriteLine();
            }
        }

        public static bool DecideWinner(String[,] board)
        {
            int i, j, x = 0, o = 0;

            //Checking for diagonal matches
            bool result = false;

            //Checking for left diagonal matches
            for (i = 0, j = 0; i < board.GetLength(0) && j < board.GetLength(1); i++, j++)
            {
                if (board[i, j] == "X")
                {
                    x++;
                }
                else if (board[i, j] == "O")
                {
                    o++;
                }
                else
                {
                    continue;
                }
            }

            if ((x == i) || (o == i))
            {
                result = true;   //left diagonal has X/O matches
            }
            else
            {
                x = 0;
                o = 0;
            }

            //Checking for right diagonal matches
            for (i = 0, j = board.GetLength(1) - 1; i < board.GetLength(0) && j >= 0; i++, j--)
            {
                if (board[i, j] == "X")
                {
                    x++;
                }
                else if (board[i, j] == "O")
                {
                    o++;
                }
                else
                {
                    continue;
                }
            }

            if ((x == i) || (o == i))
            {
                result = true;   //right diagonal has X/O matches
            }
            else
            {
                x = 0;
                o = 0;
            }

            //Checking for horizontal matches
            for (i = 0; i < board.GetLength(0); i++)
            {
                for (j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == "X")
                    {
                        x++;
                    }
                    else if (board[i, j] == "O")
                    {
                        o++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if ((x == j) || (o == j))
                {
                    result = true;   //ith row has X/O matches
                    //break;
                }
                else
                {
                    x = 0;
                    o = 0;
                    continue;

                }
            }

            //Checking for vertical matches
            for (j = 0; j < board.GetLength(1); j++)
            {
                for (i = 0; i < board.GetLength(0); i++)
                {
                    if (board[i, j] == "X")
                    {
                        x++;
                    }
                    else if (board[i, j] == "O")
                    {
                        o++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if ((x == i) || (o == i))
                {
                    result = true;   //ith row has X/O matches
                    //break;
                }
                else
                {
                    x = 0;
                    o = 0;
                    continue;
                }
            }
            
            return result;
        }

        //To print the game Array/Grid whenever needed
        public static void PrintGameArray(String[,] gameArray)
        {
            Console.Clear();
            Console.WriteLine("   TIC TAC TOE   ");
            for (int i = 0; i < gameArray.GetLength(0); i++)
            {
                Console.WriteLine("     |     |     ");
                for (int j = 0; j < gameArray.GetLength(1); j++)
                {
                    Console.Write("  " + gameArray[i, j] + "  ");
                    if(j < gameArray.GetLength(1) - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < gameArray.GetLength(0) - 1)
                {
                    Console.WriteLine("_____|_____|_____");
                }
                else
                {
                    Console.WriteLine("     |     |     ");
                }
                //Console.WriteLine("   |   |   ");
            }
            Console.WriteLine();
        }

        //Check if player can play at the current position
        public static bool VerifyGridPosition(String pos, String[,] gameArray)
        {
            bool result = false;
            for (int i = 0; i < gameArray.GetLength(0); i++)
            {
                for (int j = 0; j < gameArray.GetLength(1); j++)
                {
                    if (gameArray[i,j] == pos)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the \"Tic Tac Toe\" game!\nEnter 1 to start the game!");

            //Read User's input and accordingly start the game or exit the game!
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 2) 
            {
                Console.WriteLine("Oops! You've entered an invalid input. Please enter a valid input.\nEnter 1 to start the game and 2 to exit the game.");
            }
            if (userInput == 1)
            {
                Console.WriteLine("\n====================================\nHere is the list of rules:\n1. The game is played between two players.\n2. Every player's chance will come one-by-one and will be designated either X/O.\n3. When the chance comes, the player has to choose a position to enter their respective X/O.\n4. The player who first puts 3 X/O horizontally, vertically, diagonally wins the game.\n====================================\nHere is the grid:");

                //Ask for player's name and playing symbol
                String[] Players = new string[2];
                String[] Symbol = new string[2];
                for (int i = 0; i < Players.Length; i ++)
                {
                    Console.WriteLine($"Enter the name of player {i+1}");
                    Players[i] = Console.ReadLine();

                    if(i == 0)
                    {
                        Console.WriteLine($"{Players[i]} Which symbol you'd like to use from X/O?\nEnter 1 for X & 2 for O.");
                        int num;
                        while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 2)
                        {
                            Console.WriteLine("Oops! You've entered an invalid input. Please enter a valid input.\nEnter 1 for X & 2 for O.");
                        }
                        if(num == 1)
                        {
                            Symbol[i] = "X";
                            Symbol[i + 1] = "O";
                        }
                        else
                        {
                            Symbol[i] = "O";
                            Symbol[i + 1] = "X";
                        }
                        Console.WriteLine($"{Players[i]} You've got {Symbol[i]}.");
                    }
                    else
                    {
                        Console.WriteLine($"{Players[i]} You've got {Symbol[i]}.");
                    }
                }
                
                String winner = null;

                //Animation
                Console.Clear();
                for (int m = 0; m < 5; m++)
                {
                    for (int n = 0; n < 16; n++)
                    {
                        Console.Write("*");
                        Thread.Sleep(10);
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                //Create the grid for tic tac toe game using array
                String[,] gameGrid = new String[,]
                {
                    {"1", "2", "3" },
                    {"4", "5", "6" },
                    {"7", "8", "9" }
                };

                //Print Game grid for once(in beginning)
                PrintGameArray(gameGrid);

                //Decide that who'd like to go first
                Console.WriteLine($"Which Player would like to go first? {Players[0]} or {Players[1]}.\nEnter 1 for {Players[0]} and 2 for {Players[1]}.");
                //Console.ReadLine();
                int player;
                while (!int.TryParse(Console.ReadLine(), out player) || player < 1 || player > 2)
                {
                    Console.WriteLine($"Oops! You've entered an invalid input. Please enter a valid input.\nEnter 1 for {Players[0]} and 2 for {Players[1]}.");
                }
                if (player == 1)
                {
                    Console.WriteLine($"Alrighty, {Players[0]} will go first!");
                }
                else
                {
                    Console.WriteLine($"Alrighty, {Players[1]} will go first!");
                }
                player--;

                //Make iterations untill there's a winner
                String posxn;

                //Print the game array
                PrintGameArray(gameGrid);

                for (int t = 0; t < gameGrid.GetLength(0)*gameGrid.GetLength(1); t++)
                {
                    //Ask the input from the player
                    Console.WriteLine($"{Players[player]}, Enter the place from the grid where you want to play your chance!:");
                    posxn = Console.ReadLine();
                   
                    //Check if the entered game position is valid
                    while(VerifyGridPosition(posxn, gameGrid) != true)
                    {
                        Console.WriteLine("Oops! You've entered an invalid input. Please enter a valid position available in the grid:");
                        posxn = Console.ReadLine();
                    }

                    //Update the game grid with the player's valid input
                    UpdateGameArray(gameGrid, posxn, Symbol[player]);

                    //Print the game array
                    PrintGameArray(gameGrid);

                    //Check if there's a winner
                    if (DecideWinner(gameGrid) == true)
                    {
                        winner = Players[player];
                        Console.WriteLine($"Voila! {winner} has won the game!!!!!!\nCongratulations {winner}! for winning!!!!");
                        break;
                    }

                    //Update next player's turn
                    player = player ^ 1;
                }
                if(winner == null)
                {
                    Console.WriteLine("Uhh-ohh!!! It's a TIE.\nWe've reached the end of the game. Thanks for playing.");
                }
            }
            else
            {
                Console.WriteLine("You've exited the game. Please close this window");
            }

        }
    }
} 