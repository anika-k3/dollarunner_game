using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] DollarText dollarText;
    int dollarCount;

    private void OnEnable()
    {
        Dollar.OnDollarCollected += HandleDollarPickup;
    }

    private void OnDisable()
    {
        Dollar.OnDollarCollected -= HandleDollarPickup;
    }

    void HandleDollarPickup()
    {
        dollarCount++;
        dollarText.IncrementDollarCount(dollarCount);

        CheckHighScore();
    }

    void CheckHighScore()
    {
        if (dollarCount > PlayerPrefs.GetInt("High Score",0))
        {

            PlayerPrefs.SetInt("High Score", dollarCount);
        }
    }
}
