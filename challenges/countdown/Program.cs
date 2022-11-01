using System;

namespace countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown(10);
        }

        // Recursive method counting down to 1
        static void Countdown(int x)
        {
            if (x == 0) return;
            Console.WriteLine(x);
            Countdown(x - 1);
        }
    }
}
