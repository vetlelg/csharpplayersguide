using System;

namespace buying_inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(
                "The following items are available:\n" +
                "1 - Rope\n" +
                "2 - Torches\n" +
                "3 - Climbing Equipment\n" +
                "4 - Clean Water\n" +
                "5 - Machete\n" +
                "6 - Canoe\n" +
                "7 - Food Supplies\n" +
                "What number do you want to see the price of? "
            );
            byte equipmentNumber = Convert.ToByte(Console.ReadLine());
            string name = "Vetle";
            Console.Write("What's your name? ");
            string username = Console.ReadLine();
            string response;
            if (name.Equals(username))
            {
                response = equipmentNumber switch
                {
                    1 => "Rope cost 5 gold.",
                    2 => "Torches cost 7.5 gold.",
                    3 => "Climbing Equipment cost 12.5 gold.",
                    4 => "Clean Water cost 0.5 gold.",
                    5 => "Machete cost 10 gold.",
                    6 => "Canoe cost 100 gold.",
                    7 => "Food Supplies cost 0.5 gold.",
                    _ => "Sorry. That's we do not have that in inventory."
                };
            }
            else
            {
                response = equipmentNumber switch
                {
                    1 => "Rope cost 10 gold.",
                    2 => "Torches cost 15 gold.",
                    3 => "Climbing Equipment cost 25 gold.",
                    4 => "Clean Water cost 1 gold.",
                    5 => "Machete cost 20 gold.",
                    6 => "Canoe cost 200 gold.",
                    7 => "Food Supplies cost 1 gold.",
                    _ => "Sorry. That's we do not have that in inventory."
                };    
            }
            Console.WriteLine(response);
        }
    }
}
