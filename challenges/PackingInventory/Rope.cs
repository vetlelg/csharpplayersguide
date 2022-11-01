using System;

namespace PackingInventory
{
    public class Rope : InventoryItem
    {
        public Rope() : base(1, 1.5)
        {

        }

        public override string ToString()
        {
            return "Rope";
        }
    }
}