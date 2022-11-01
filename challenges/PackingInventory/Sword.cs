using System;

namespace PackingInventory
{
    public class Sword : InventoryItem
    {
        public Sword() : base(5, 3)
        {
        }

        public override string ToString()
        {
            return "Sword";
        }
        
    }
}