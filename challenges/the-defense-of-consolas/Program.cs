using System;

namespace the_defense_of_consolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";

            // Read target row from user
            Console.Write("Target Row? ");
            byte row = Convert.ToByte(Console.ReadLine());

            // Read target column from user
            Console.Write("Target Column? ");
            byte col = Convert.ToByte(Console.ReadLine());

            // Change the text color displayed in the console
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Compute neighboring where to deploy the squad and print the results to console
            Console.Write(
                "Deploy to:\n" +
                $"({row}, {col-1})\n" +
                $"({row-1}, {col})\n" +
                $"({row}, {col+1})\n" +
                $"({row+1}, {col})\n"
            );

            // Change text color back to white
            Console.ForegroundColor = ConsoleColor.White;

            // Play sound when the results have been computed and displayed
            Console.Beep(440, 1000);

        }
    }
}
