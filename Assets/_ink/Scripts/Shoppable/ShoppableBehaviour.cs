using UnityEngine;

namespace ink.Shop
{
    public abstract class ShoppableBehaviour: MonoBehaviour
    {
        public abstract void AddBoughtItem(Item item);
    }
}
