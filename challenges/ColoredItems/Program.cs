using System;

namespace ColoredItems
{
    class Program
    {
        static void Main(string[] args)
        {
            ColoredItem<Sword> coloredSword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
            ColoredItem<Bow> coloredBow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
            ColoredItem<Axe> coloredAxe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

            coloredSword.Display();
            coloredBow.Display();
            coloredAxe.Display();
        }
    }
}
