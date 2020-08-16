using UnityEngine;

namespace ink.Shop
{
    public class ShopabbleBehaviour : MonoBehaviour
    {
        public string objectState;

        public void ChangeState(Item newState)
        {
            objectState = newState.name;
        }
    }
}