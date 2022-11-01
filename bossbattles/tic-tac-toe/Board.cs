using System;

namespace TicTacToe
{

    public class Board
    {
        // Array holding the state of the board. Board contains 9 squares.
        // Index 0-8 representing the 9 squares on the board
        public char[] BoardState { get; }  = {' ',' ',' ',' ',' ',' ',' ',' ',' '};

        public void Update(int square, char marker) => BoardState[square-1] = marker;

        public bool IsFull()
        {
            foreach (char state in BoardState) if (state == ' ') return false;
            return true;
        }

        // Check if X or O (marker) is occupying three consecutive rows, columns or diagonals
        public bool PlayerHasWon(char marker)
        {
            if (BoardState[0] == marker && BoardState[1] == marker && BoardState[2] == marker) return true;
            if (BoardState[0] == marker && BoardState[3] == marker && BoardState[6] == marker) return true;
            if (BoardState[0] == marker && BoardState[4] == marker && BoardState[8] == marker) return true;
            if (BoardState[1] == marker && BoardState[4] == marker && BoardState[7] == marker) return true;
            if (BoardState[2] == marker && BoardState[4] == marker && BoardState[6] == marker) return true;
            if (BoardState[2] == marker && BoardState[5] == marker && BoardState[8] == marker) return true;
            if (BoardState[3] == marker && BoardState[4] == marker && BoardState[5] == marker) return true;
            if (BoardState[6] == marker && BoardState[7] == marker && BoardState[8] == marker) return true;
            return false;
        }

        public bool SquareIsTaken(int square) => BoardState[square-1] != ' ';
    }

}