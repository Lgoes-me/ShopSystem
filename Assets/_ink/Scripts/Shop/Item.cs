using UnityEngine;

namespace ink.Shop
{
    [CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Shop/Item", order = 1)]
    public class Item : ScriptableObject
    {
        public string itemName;
        public Sprite itemSprite;
        public int price;
    }
}
