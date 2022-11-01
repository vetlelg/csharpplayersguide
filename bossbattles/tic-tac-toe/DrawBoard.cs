using System;

namespace TicTacToe
{

    public class DrawBoard
    {
        public void Draw(char[] boardState)
        {
            Console.Write(
                $" {boardState[6]} | {boardState[7]} | {boardState[8]} \n" +
                $"---+---+---\n" +
                $" {boardState[3]} | {boardState[4]} | {boardState[5]} \n" +
                $"---+---+---\n" +
                $" {boardState[0]} | {boardState[1]} | {boardState[2]} \n"
            );
        }
    }

}