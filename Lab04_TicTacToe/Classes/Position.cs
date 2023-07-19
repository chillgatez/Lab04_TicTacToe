using System;

namespace Lab04_TicTacToe.Classes
{
    class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        /// <summary>
        /// Position on the game board being initialized 
        /// </summary>
        /// <param name="row">row number</param>
        /// <param name="column">column number</param>
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        /// <summary>
        /// Converts the position number to a corresponding Position object.
        /// </summary>
        /// <param name="positionNumber">The position number (1 to 9).</param>
        /// <returns>The Position object corresponding to the position number.</returns>
        public static Position PositionForNumber(int positionNumber)
        {
            int row = (positionNumber - 1) / 3;
            int column = (positionNumber - 1) % 3;
            return new Position(row, column);
        }

        /// <summary>
        /// Converts the Position to its corresponding position number.
        /// </summary>
        /// <returns>The position number (1 to 9) corresponding to the Position.</returns>
        public int ToPositionNumber()
        {
            return (Row * 3) + Column + 1;
        }
    }
}
