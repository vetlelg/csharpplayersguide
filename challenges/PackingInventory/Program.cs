using System;

namespace PackingInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack(10, 20, 20);
            while (true)
            {
                Console.WriteLine(pack.ToString());
                Console.WriteLine($"Inventory is currently at {pack.NumberOfItems} items. Weight is {pack.Weight} and volume is {pack.Volume}.");
                Console.WriteLine($"What item do you want to add to your inventory?");
                Console.WriteLine($"1 - Arrow");
                Console.WriteLine($"2 - Bow");
                Console.WriteLine($"3 - Rope");
                Console.WriteLine($"4 - Water");
                Console.WriteLine($"5 - Food");
                Console.WriteLine($"6 - Sword");
                int choice = Convert.ToInt32(Console.ReadLine());
                InventoryItem item = choice switch
                {
                    1 => new Arrow(),
                    2 => new Bow(),
                    3 => new Rope(),
                    4 => new Water(),
                    5 => new Food(),
                    6 => new Sword()
                };

                if (!pack.Add(item))
                {
                    Console.WriteLine("Unable to add item to inventory. Inventory full.");
                    break;
                }
            }
        }
    }
}
