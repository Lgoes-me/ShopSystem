using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ink.Shop
{
    public class ShopItemUI : MonoBehaviour
    {
        public Shop shop;
        public Item item;
        public ShoppableBehaviour shopable;

        public Image image;
        public TMP_Text Name;
        public TMP_Text Value;

        public void OnEnable()
        {
            if(item.itemSprite != null)
            {
                image.sprite = item.itemSprite;
            }
            
            if (item.itemName != null)
            {
                Name.text = item.itemName;
            }

            if (item.price != 0)
            {
                Value.text = item.price.ToString("00"); ;
            }
        }

        public void Buy()
        {
            if (shop.CheckAndPay(item.price))
            {
                shopable.AddBoughtItem(item);
            }
        }
    }
}
