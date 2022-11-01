using System;

namespace the_prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pick a number between 0 and 100. Keep looping if too high or too low
            short number;
            do
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                number = Convert.ToInt16(Console.ReadLine());
            }
            while (number < 0 || number > 100);
            
            // Clear console after number has been picked
            Console.Clear();

            // Guess number. Keep looping if guess not equals number picked
            Console.WriteLine("User 2, guess the number.");
            short guess;
            do
            {
                Console.Write("What is your next guess? ");
                guess = Convert.ToInt16(Console.ReadLine());
                if (guess > number)
                    Console.WriteLine($"{guess} is too high.");
                else if (guess < number)
                    Console.WriteLine($"{guess} is too low.");
                else
                    Console.WriteLine("You guessed the number!");

            }
            while (number != guess);

        }
    }
}
