using System;

namespace PackingInventory
{
    public class Pack
    {
        private InventoryItem[] Inventory { get; }
        private int MaxNumberOfItems { get; }
        private double MaxWeight { get; }
        private double MaxVolume { get; }
        public int NumberOfItems { get; private set; } = 0;
        public double Weight { get; private set; } = 0;
        public double Volume { get; private set; } = 0;
        
        public Pack(int maxNumberOfItems, double maxWeight, double maxVolume)
        {
            Inventory = new InventoryItem[maxNumberOfItems];
            MaxNumberOfItems = maxNumberOfItems;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
        }

        public override string ToString()
        {
            string pack = "Pack containing";
            foreach (var item in Inventory)
            {
                if (item == null) break;
                pack += $" {item.ToString()}";
            }
            return pack;
        }

        public bool Add(InventoryItem newItem)
        {
            int itemCounter = 0;
            double weight = 0, volume = 0;
            foreach (InventoryItem item in Inventory)
            {
                if (item == null) break;
                weight += item.Weight;
                volume += item.Volume;
                itemCounter++;
            }

            if (itemCounter >= MaxNumberOfItems || weight >= MaxWeight || volume >= MaxVolume)
                return false;

            Inventory[NumberOfItems] = newItem;
            Weight += newItem.Weight;
            Volume += newItem.Volume;
            NumberOfItems++;
            return true;
        }
    }

}
