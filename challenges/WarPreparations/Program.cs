using System;

namespace WarPreparations
{
    class Program
    {
        static void Main(string[] args)
        {
            Sword ironSword = new Sword(Material.Iron, Gemstone.None, 5.0f, 3.0f);
            Sword steelEmeraldSword = ironSword with { Material = Material.Steel, Gemstone = Gemstone.Emerald };
            Sword bronzeAmberSword = ironSword with { Material = Material.Bronze, Gemstone = Gemstone.Amber };
            Console.WriteLine(ironSword);
            Console.WriteLine(steelEmeraldSword);
            Console.WriteLine(bronzeAmberSword);
        }
    }
}
