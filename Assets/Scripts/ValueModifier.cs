using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ValueModifier : MonoBehaviour
{
    public float value;
    public float changeInValue;
    public TextMeshProUGUI valueText;

    void Start()
    {
        UpdateValueText();
    }

    void UpdateValueText()
    {
        valueText.text = value.ToString();
    }

    public void Increase()
    {
        value += changeInValue;
        UpdateValueText();
    }

    public void Decrease()
    {
        value -= changeInValue;
        UpdateValueText();
    }
}
