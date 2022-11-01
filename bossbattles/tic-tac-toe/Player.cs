using System;

namespace TicTacToe
{

    public class Player
    {
        public char Marker { get; }
        public Player(char marker)
        {
            Marker = marker;
        }

        // Get input from user, using the numpad. Numbers 1-9 representing the squares on the board
        // Continue asking if the square is taken
        public int GetSquare(Board board)
        {
            int square;
            do
            {
                Console.WriteLine("What square do you want to play in?");
                square = Convert.ToInt32(Console.ReadLine());
            } while (board.SquareIsTaken(square));
            return square;
        }
    }

}