using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DollarText : MonoBehaviour
{
    public TextMeshProUGUI dollarText;

    public void IncrementDollarCount(int dollarTotal)
    {
        dollarText.text = $"Dollars:{dollarTotal}";
    }
}
