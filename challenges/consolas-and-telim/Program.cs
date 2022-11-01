using System;

namespace consolas_and_telim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            string name = Console.ReadLine();
            Console.WriteLine($"Noted: {name} got bread.");
        }
    }
}
