using UnityEngine;
using TMPro;
using ScriptableObjectArchitecture;


public class IntToTextControl : MonoBehaviour
{
    public IntVariable intValue;
    public TMP_Text textElement;

    public void OnEnable()
    {
        UpdateValue();
    }

    public void UpdateValue()
    {
        textElement.text = intValue.Value.ToString("00");
    }
}
