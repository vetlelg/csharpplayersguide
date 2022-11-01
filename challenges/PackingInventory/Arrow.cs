using System;

namespace PackingInventory
{
    public class Arrow : InventoryItem
    {
        public Arrow() : base(0.1, 0.05)
        {
            
        }

        public override string ToString()
        {
            return "Arrow";
        }
    }
}