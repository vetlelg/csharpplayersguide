using System;
using System.Collections.Generic;

namespace ExeptisGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int raisinCookie = new Random().Next(10);
            List<int> numbers = new List<int>();

            try
            {
                while (true)
                {
                    int number;
                    while (true)
                    {
                        Console.WriteLine("Guess a number between 0 and 9");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number < 0 || number > 9)
                            Console.WriteLine("Number is not between 0 and 9");
                        else if (numbers.Contains(number))
                            Console.WriteLine("Number has already been guessed");
                        else
                            break;
                    }

                    if (number == raisinCookie) throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You ate the raisin cookie. You lose!");
            }
        }
    }
}
