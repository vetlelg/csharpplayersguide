using System;

namespace ColoredItems
{
    public class ColoredItem<T>
    {
        private T Item { get; }
        private ConsoleColor Color { get; }

        public ColoredItem(T item, ConsoleColor color)
        {
            Color = color;
            Item = item;
        }

        public void Display()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"{Color} {Item}");
        }

    }
}