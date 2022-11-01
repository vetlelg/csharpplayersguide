using System;

namespace PackingInventory
{
    public class InventoryItem
    {
        public double Weight { get; }
        public double Volume { get; }

    public InventoryItem(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }
    }
}
