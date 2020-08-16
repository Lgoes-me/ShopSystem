using System.Collections.Generic;

namespace ink.Shop
{
    public class ShoppableInventory : ShoppableBehaviour
    {
        public List<Item> itens;

        public void Awake()
        {
            itens = new List<Item>();
        }

        public override void AddBoughtItem(Item item)
        {
            itens.Add(item);
        }
    }
}
