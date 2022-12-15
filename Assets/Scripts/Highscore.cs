using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighscoreText : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;

    public void IncrementHighscore(int totalMoney)
    {
        highscoreText.text = $"Dollar: {totalMoney}";
    }
}
