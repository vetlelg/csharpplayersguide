using System;

namespace the_magic_cannon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop from 1 to 100
            for (int i = 1; i < 101; i++)
            {
                // If i divisible by 3 and 5, print electric and fire in blue
                // If i divisible by 3, print fire in red
                // If i divisible by 5, print eletric in yellow
                // Else print normal in white
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}: Electric and Fire");
                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}: Fire");
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}: Electric");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{i}: Normal");
                }
            }
        }
    }
}
