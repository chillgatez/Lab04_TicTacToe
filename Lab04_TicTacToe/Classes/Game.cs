using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Player Winner { get; set; }
        public Board Board { get; set; }


        /// <summary>
        /// Require 2 players and a board to start a game. 
        /// </summary>
        /// <param name="p1">Player 1</param>
        /// <param name="p2">Player 2</param>
        public Game(Player p1, Player p2)
        {
            PlayerOne = p1;
            PlayerTwo = p2;
            Board = new Board();
        }

        /// <summary>
        /// Activate the Play of the game
        /// </summary>
        /// <returns>Winner</returns>
        public Player Play()
        {

            //TODO: Complete this method and utilize the rest of the class structure to play the game.

            /*
             * Complete this method by constructing the logic for the actual playing of Tic Tac Toe. 
             * 
             * A few things to get you started:
            1. A turn consists of a player picking a position on the board with their designated marker. 
            2. Display the board after every turn to show the most up to date state of the game
            3. Once a Winner is determined, display the board one final time and return a winner

            Few additional hints:
                Be sure to keep track of the number of turns that have been taken to determine if a draw is required
                and make sure that the game continues while there are unmarked spots on the board. 

            Use any and all pre-existing methods in this program to help construct the method logic. 
             */

            Player currentPlayer = PlayerOne;

            // Game loop until a winner is determined or the board is full (draw).
            while (!CheckForWinner(Board) && !IsBoardFull())
            {

                currentPlayer.TakeTurn(Board);
                Board.DisplayBoard();
                currentPlayer = (currentPlayer == PlayerOne) ? PlayerTwo : PlayerOne;
            }

            // Determine the winner or return null if it's a draw.
            Winner = GetWinner();
            if (Winner != null)
            {
                Console.WriteLine($"Congratulations, {Winner.Name} has won the game!");
            }
            else
            {
                Console.WriteLine("The game ended in a draw. No winner!");
            }

            return Winner;
        }


        /// <summary>
        /// Check if winner exists
        /// </summary>
        /// <param name="board">current state of the board</param>
        /// <returns>if winner exists</returns>
        public bool CheckForWinner(Board board)
        {
            int[][] winners = new int[][]
            {
                new[] {1,2,3}, // Top row
                new[] {4,5,6}, // Middle row
                new[] {7,8,9}, // Bottom row

                new[] {1,4,7}, // Left column
                new[] {2,5,8}, // Middle column
                new[] {3,6,9}, // Right column

                new[] {1,5,9}, // Diagonal from top-left to bottom-right
                new[] {3,5,7}
            };

            // Given all the winning conditions, Determine the winning logic. 
            for (int i = 0; i < winners.Length; i++)
            {
                Position p1 = Player.PositionForNumber(winners[i][0]);
                Position p2 = Player.PositionForNumber(winners[i][1]);
                Position p3 = Player.PositionForNumber(winners[i][2]);

                string a = board.Board[p1.Row, p1.Column];
                string b = board.Board[p2.Row, p2.Column];
                string c = board.Board[p3.Row, p3.Column];

                // TODO:  Determine a winner has been reached. 
                // return true if a winner has been reached. 

                if (a == b && b == c && !string.IsNullOrEmpty(a) && !string)

            }

            return false;
        }


        /// <summary>
        /// Determine next player
        /// </summary>
        /// <returns>next player</returns>
        public Player NextPlayer()
        {
            return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
        }

        /// <summary>
        /// End one players turn and activate the other
        /// </summary>
        public void SwitchPlayer()
        {
            if (PlayerOne.IsTurn)
            {

                PlayerOne.IsTurn = false;


                PlayerTwo.IsTurn = true;
            }
            else
            {
                PlayerOne.IsTurn = true;
                PlayerTwo.IsTurn = false;
            }
        }


    }
}