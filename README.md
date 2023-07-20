# Lab04_TicTacToe

## Summary

This is a simple command-line TicTacToe game built in C#. The game allows two players to take turns placing their markers ('X' and 'O') on a 3x3 grid. The first player to align three of their markers either horizontally, vertically, or diagonally wins the game. If the entire grid is filled without a winner, the game ends in a draw.

## Visuals

Here's a brief demonstration of how the game looks in action:



## How to Play

1. Run the program.
2. Enter the name of Player 1 (the first player who will use 'X' marker).
3. Enter the name of Player 2 (the second player who will use 'O' marker).
4. The initial empty game board will be displayed.
5. Players will take turns to select an available slot on the board by entering the corresponding number (1-9).
6. The game will automatically check if the selected slot is valid (not already occupied) and update the board accordingly.
7. The game continues until a player wins or the board is filled completely (draw).
8. If a player wins, the program will display a congratulatory message with the name of the winner.
9. If the game ends in a draw, it will be displayed as well.

## Additional Details

- The program ensures that players can only select empty slots on the board and will prompt the player to choose again if they select an occupied slot.
- The game automatically detects the winner after each turn and displays the outcome accordingly.
- The game is implemented using object-oriented programming principles, with a `Player` class to represent players and a `WinnerOfTheGame` method to check for a win condition.
- The board is represented as a 3x3 grid, with each slot numbered from 1 to 9, making it easy for players to select their moves.
- The code is well-structured and easy to understand, making it a fun and engaging TicTacToe experience!

Enjoy playing the TicTacToe game and have fun!
