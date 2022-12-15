using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighscoreNew : MonoBehaviour
{
    [SerializeField] movement_city movement_City;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = movement_City.score.ToString();
        highscoreText.text = movement_City.highscore.ToString();
    }
}
