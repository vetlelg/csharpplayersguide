using System;

namespace repairing_the_clocktower
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read number from console
            Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // If number is even, display tick to console. Else display tock.
            if (number % 2 == 0)
                Console.WriteLine("Tick"); // Even
            else
                Console.WriteLine("Tock"); // Odd
        }
    }
}
