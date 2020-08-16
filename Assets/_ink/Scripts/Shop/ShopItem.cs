using UnityEngine;

namespace ink.Shop
{
    public class ShopItem : MonoBehaviour
    {
        public Shop shop;
        public Item item;
        public ShopabbleBehaviour shopable;

        public void Buy()
        {
            if (shop.CheckAndPay(item.price))
            {
                shopable.ChangeState(item);
            }
        }
    }
}
