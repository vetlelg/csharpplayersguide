using System;

namespace PackingInventory
{
    public class Water : InventoryItem
    {
        public Water() : base(2, 3)
        {

        }

        public override string ToString()
        {
            return "Water";
        }
        
    }
}