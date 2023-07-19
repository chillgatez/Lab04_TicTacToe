using System;

namespace Lab04_TicTacToe.Classes
{
    public class Player
    {
        public Player(string name, string marker)
        {
            Name = name;
            Marker = marker;
        }
        public string Name { get; set; }
        /// <summary>
        /// P1 is X and P2 will be O
        /// </summary>
        /// 
        public string Marker { get; set; }
       
        /// <summary>
        /// Flag to determine if it is the user's turn
        /// </summary>
        public bool IsTurn { get; set; }
        public void TakeTurn(Board board)
        {
            Console.WriteLine($"{Name}, it's your turn. Please enter a number from 1 to 9 to place your marker.");
            bool validInput = false;
            int selectedPosition;

            while (!validInput)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out selectedPosition))
                {
                    if (selectedPosition >= 1 && selectedPosition <= 9)
                    {
                        Position position = Position.PositionForNumber(selectedPosition);
                        if (board.GameBoard[position.Row, position.Column] == "")
                        {
                            board.GameBoard[position.Row, position.Column] = Marker;
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("That position is already taken. Please choose an empty position.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 9.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
