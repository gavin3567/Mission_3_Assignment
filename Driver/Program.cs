using System;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Threading;

namespace Driver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // initialized userName variable
            string player1 = "";
            string player2 = "";

            // Create a game board array to store the players’ choices
            char[] positions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            // initialize the board

            static void Board(char[] positions)
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", positions[1], positions[2], positions[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", positions[4], positions[5], positions[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", positions[7], positions[8], positions[9]);
                Console.WriteLine("     |     |      ");
            }

            // prompt user for name of player 1
            Console.WriteLine("What is player 1's name?");

            // store name in userName variable
            player1 = Console.ReadLine();

            // prompt user for name of player 2
            Console.WriteLine("What is player 2's name?");

            // store name in userName variable
            player2 = Console.ReadLine();

            // Welcome the user to the game
            Console.WriteLine("Welcome " + player1 + " " + player2 + " to the online Tic-Tac-Toe game!");

            // Ask each player in turn for their choice and update the game board array

            // Print the board by calling the method in the supporting class

            // Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game

            Board(positions);
        }
    }
}

// 1-9 options

