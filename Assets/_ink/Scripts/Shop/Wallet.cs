using UnityEngine;
using ScriptableObjectArchitecture;

namespace ink.Shop
{
    public class Wallet : MonoBehaviour
    {
        public IntVariable moneyAmount;

        public void Pay(int value) => moneyAmount.Value -= value;
        public bool CheckFunds(int value) => moneyAmount.Value >= value;
    }
}
