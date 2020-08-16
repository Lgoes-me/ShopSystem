namespace ink.Shop
{
    public class ShoppableInstance : ShoppableBehaviour
    {
        public Item currentState;

        public override void AddBoughtItem(Item item)
        {
            currentState = item;
        }
    }
}