using UnityEngine;

namespace ink.Shop
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Shop/Item", order = 1)]
    public class Item : ScriptableObject
    {
        public string itemName;
        public Sprite itemSprite;
        public int Value;
    }
}
