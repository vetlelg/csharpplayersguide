using System;

namespace TicTacToe
{

    public class TicTacToeGame
    {
        private Board Board { get; } = new Board();
        private Player PlayerX { get; } = new Player('X');
        private Player PlayerO { get; } = new Player('O');
        private DrawBoard DrawBoard { get; } = new DrawBoard();
        private bool IsPlayerXTurn { get; set; } = true;
        private Player Player { get; set; }

        public TicTacToeGame()
        {
            Player = PlayerX;
        }

        // Start the game. Call this method in the main method
        public void Run()
        {
            // Loop until game is over
            while(!IsGameOver())
            {
                if (IsPlayerXTurn) Player = PlayerX;
                else Player = PlayerO;
                IsPlayerXTurn = !IsPlayerXTurn;

                Console.WriteLine($"It is {Player.Marker}'s turn");
                DrawBoard.Draw(Board.BoardState);
                Board.Update(Player.GetSquare(Board), Player.Marker);

                if (IsGameOver())
                {
                    Console.WriteLine("Game over!");
                    DrawBoard.Draw(Board.BoardState);
                }
            }
        }

        // Game is over when the board is full or if any player has won
        private bool IsGameOver()
        {
            return Board.IsFull() || Board.PlayerHasWon(Player.Marker);
        }
    }

}