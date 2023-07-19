using System;

namespace Lab04_TicTacToe.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            Console.WriteLine("Hi. Let's play TicTacToe!!");
            Console.Write("Player1's name: ");
            string player1name = Console.ReadLine();
            Player player1 = new Player(player1name, "X");
            Console.Write("Player2's name: ");
            string player2name = Console.ReadLine();
            Player player2 = new Player(player2name, "O");
            Console.WriteLine("====== {0} vs {1} =====", player1.Name, player2.Name);

            // Create the game instance
            Game game = new Game(player1, player2);

            // Start the game
            Player winner = game.Play();

            // Determine the winner and output the celebratory message to the correct player. If it's a draw, tell them that there is no winner.
            if (winner != null)
            {
                string winningPlayerName = (winner == player1) ? player1.Name : player2.Name;
                Console.WriteLine($"Congratulations, {winningPlayerName} has won the game!");
            }
            else
            {
                Console.WriteLine("The game ended in a draw. No winner!");
            }
        }
    }
}
