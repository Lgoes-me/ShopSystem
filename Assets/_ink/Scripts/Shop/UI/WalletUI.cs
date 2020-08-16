using UnityEngine;
using TMPro;

namespace ink.Shop
{
    public class WalletUI : MonoBehaviour
    {
        public TMP_Text ammount;
        public Wallet wallet;

        public void Refresh() => ammount.text = wallet.moneyAmount.Value.ToString("00");
    }
}