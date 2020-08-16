using UnityEngine;
using ScriptableObjectArchitecture;

namespace ink.Shop
{
    public class Shop : MonoBehaviour
    {
        public IntVariable moneyAmount;

        public bool CheckAndPay(int value)
        {
            if(moneyAmount.Value >= value)
            {
                moneyAmount.Value -= value;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
