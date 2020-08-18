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
        public int ammountOfItensOnShop = 1;

        public Button button;
        public Image image;
        public TMP_Text Name;
        public TMP_Text Ammount;
        public TMP_Text Value;

        public void OnEnable()
        {
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            if (item.itemSprite != null && image != null)
            {
                image.sprite = item.itemSprite;
            }

            if (item.itemName != null && Name != null)
            {
                Name.text = item.itemName;
            }

            if (item.price != 0 && Value != null)
            {
                Value.text = item.price.ToString("0");
            }

            if (ammountOfItensOnShop > 0 && Ammount != null)
            {
                Ammount.text = ammountOfItensOnShop.ToString("0");
            }
            else
            {
                Ammount.gameObject.SetActive(false);
            }
            
            if (ammountOfItensOnShop == 0)
            {
                button.interactable = false;
                Ammount.gameObject.SetActive(false);
            }
        }

        public void Buy()
        {
            if (ammountOfItensOnShop == 0)
            {
                button.interactable = false;
                Ammount.gameObject.SetActive(false);
                return;
            }

            if (shop.CheckAndPay(item.price))
            {
                shopable.AddBoughtItem(item);

                ammountOfItensOnShop -= 1;

                UpdateDisplay();
            }
        }
    }
}
