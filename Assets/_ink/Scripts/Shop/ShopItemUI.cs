using UnityEngine;

namespace ink.Shop
{
    public class ShopItemUI : MonoBehaviour
    {
        public Shop shop;
        public Item item;
        public ShoppableBehaviour shopable;

        public void Buy()
        {
            if (shop.CheckAndPay(item.price))
            {
                shopable.AddBoughtItem(item);
            }
        }
    }
}
