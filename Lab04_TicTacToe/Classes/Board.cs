using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
        /// <summary>
        /// Tic Tac Toe Gameboard states
        /// </summary>
        public string[,] GameBoard { get; set; }

        public Board()
        {
            GameBoard = new string[,]
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };
        }

        /// <summary>
        /// Display the Game Board
        /// </summary>
        public void DisplayBoard()
        {

            //TODO: Output the board to the console
            Console.WriteLine("|{0}||{1}||{2}|", GameBoard[0, 0], GameBoard[0, 1], GameBoard[0, 2]);
            Console.WriteLine("|{0}||{1}||{2}|", GameBoard[1, 0], GameBoard[1, 1], GameBoard[1, 2]);
            Console.WriteLine("|{0}||{1}||{2}|", GameBoard[2, 0], GameBoard[2, 1], GameBoard[2, 2]);
        }
    }
}