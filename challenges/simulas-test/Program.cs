using System;

namespace simulas_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default chest state
            ChestState state = ChestState.Locked;

            // Loop forever. Ask user for input.
            // Only accept unlock, lock, open or close as input. All other inputs are invalid.
            // Only transition between supported states.
            while (true)
            {
                Console.Write($"The chest is {state}. What do you want to do? ");
                string action = Console.ReadLine();

                if (action == "unlock" && state == ChestState.Locked) { state = ChestState.Closed; }
                else if (action == "lock" && state == ChestState.Closed) { state = ChestState.Locked; }
                else if (action == "open" && state == ChestState.Closed) { state = ChestState.Open; }
                else if (action == "close" && state == ChestState.Open) { state = ChestState.Closed; }
                else { Console.WriteLine("Invalid input. Try again."); }                
            }
            
        }

        // Define the states of the chest
        enum ChestState { Open, Closed, Locked };

    }
}
