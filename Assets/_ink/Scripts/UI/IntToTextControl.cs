using UnityEngine;
using TMPro;
using ScriptableObjectArchitecture;


public class IntToTextControl : MonoBehaviour, IGameEventListener
{
    public IntVariable intValue;
    public TMP_Text textElement;

    public void Awake()
    {
        intValue.AddListener(this);
    }

    public void OnEnable()
    {
        UpdateValue();
    }

    public void OnEventRaised()
    {
        UpdateValue();
    }

    public void UpdateValue()
    {
        textElement.text = intValue.Value.ToString("00");
    }

    public void OnDestroy()
    {
        intValue.RemoveListener(this);
    }
}
