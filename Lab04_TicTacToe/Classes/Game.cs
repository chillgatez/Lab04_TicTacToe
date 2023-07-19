using System;

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
            Player currentPlayer = PlayerOne;

            // Game loop until a winner is determined or the board is full (draw).
            while (!CheckForWinner(Board) && !IsBoardFull())
            {
                // Player takes their turn and the board is displayed.
                currentPlayer.TakeTurn(Board);
                Board.DisplayBoard();

                // Switch to the next player.
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
                new[] {1,2,3},
                new[] {4,5,6},
                new[] {7,8,9},

                new[] {1,4,7},
                new[] {2,5,8},
                new[] {3,6,9},

                new[] {1,5,9},
                new[] {3,5,7}
            };

            // Given all the winning conditions, determine the winning logic. 
            for (int i = 0; i < winners.Length; i++)
            {
                Position p1 = Position.PositionForNumber(winners[i][0]);
                Position p2 = Position.PositionForNumber(winners[i][1]);
                Position p3 = Position.PositionForNumber(winners[i][2]);

                string a = board.GameBoard[p1.Row, p1.Column];
                string b = board.GameBoard[p2.Row, p2.Column];
                string c = board.GameBoard[p3.Row, p3.Column];

                // Determine if a winner has been reached.
                if (a == b && b == c && !string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(c))
                {
                    return true;
                }
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
        /// End one player's turn and activate the other
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

        /// <summary>
        /// Check if the board is full (draw).
        /// </summary>
        /// <returns>True if the board is full, false otherwise.</returns>
        public bool IsBoardFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (string.IsNullOrEmpty(Board.GameBoard[row, col]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Get the winner of the game if one exists.
        /// </summary>
        /// <returns>The winning player if there is one, null otherwise.</returns>
        public Player GetWinner()
        {
            if (CheckForWinner(Board))
            {
                return (PlayerOne.Marker == Board.GameBoard[0, 0] ||
                        PlayerOne.Marker == Board.GameBoard[0, 1] ||
                        PlayerOne.Marker == Board.GameBoard[0, 2] ||
                        PlayerOne.Marker == Board.GameBoard[1, 0] ||
                        PlayerOne.Marker == Board.GameBoard[1, 1] ||
                        PlayerOne.Marker == Board.GameBoard[1, 2] ||
                        PlayerOne.Marker == Board.GameBoard[2, 0] ||
                        PlayerOne.Marker == Board.GameBoard[2, 1] ||
                        PlayerOne.Marker == Board.GameBoard[2, 2]) ? PlayerOne : PlayerTwo;
            }
            return null;
        }
    }
}
