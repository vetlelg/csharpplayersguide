using System;

namespace PackingInventory
{
    public class Bow : InventoryItem
    {
        public Bow() : base(1, 4)
        {

        }

        public override string ToString()
        {
            return "Bow";
        }
    }
}