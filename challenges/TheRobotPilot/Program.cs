using System;

namespace TheRobotPilot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables holding the stats of the game
            int manticoreHP = 10, cityHP = 15, round = 1;

            // Get generate random distance from city, between 0 and 100
            Random random = new Random();
            int distanceFromCity = random.Next(101);

            // Looping until either Manticore or City is destroyed
            while (manticoreHP != 0 || cityHP != 0)
            {
                // Print status to console
                PrintStatus(round, cityHP, manticoreHP);

                // Calculcate the cannonDamage based on if round is divisible by 3 or 5, or both
                int cannonDamage = CalculateCannonDamage(round);

                // Player 2 guesses distance between manticore and City
                int cannonRange = GetCannonRange();

                // Try to shoot Manticore, based on Player 2's guess
                bool manticoreWasHit = ShootManticore(distanceFromCity, cannonRange);
                bool manticoreIsDestroyed = false;

                // If Manticore was hit, make damage to Manticore and check if Manticore is destroyed
                // If Manticore is destroyed, end the game
                if (manticoreWasHit) manticoreIsDestroyed = DamageManticore(cannonDamage, ref manticoreHP);
                if (manticoreIsDestroyed) break;

                // If Manticore is still alive, make damage to city. If city is destroyed the loop will end
                DamageCity(ref cityHP);
                
                round++;
            }

            void PrintStatus(int round, int cityHP, int manticoreHP)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"STATUS: Round: {round} City: {cityHP}/15 Manticore: {manticoreHP}/10");
            }

            int CalculateCannonDamage(int round)
            {
                int cannonDamage = 1;
                if (round % 3 == 0 && round % 5 == 0)
                {
                    cannonDamage = 10;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (round % 3 == 0)
                {
                    cannonDamage = 3;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (round % 5 == 0)
                {
                    cannonDamage = 5;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
                Console.ForegroundColor = ConsoleColor.White;
                return cannonDamage;
            }

            int GetCannonRange()
            {
                int cannonRange;
                while (true)
                {
                    Console.Write("Enter desired cannon range (Number between 0 and 100) ");
                    cannonRange = Convert.ToInt32(Console.ReadLine());
                    if (cannonRange <= 100 && cannonRange >= 0) return cannonRange;
                    Console.WriteLine("Invalid input. Try again.");
                }
            }

            bool ShootManticore(int distanceFromCity, int cannonRange)
            {
                if (cannonRange < distanceFromCity)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That round FELL SHORT of the target.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
                else if (cannonRange > distanceFromCity)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That round OVERSHOT the target.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That round was a DIRECT HIT!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return true;
                }
            }

            bool DamageManticore(int cannonDamage, ref int manticoreHP)
            {
                manticoreHP -= cannonDamage;
                if (manticoreHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return true;
                }
                return false;
            }

            void DamageCity(ref int cityHP)
            {
                cityHP--;
                if (cityHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The city of Consolas has been destroyed! The Manticore is victorious!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }



        }
    }
}
