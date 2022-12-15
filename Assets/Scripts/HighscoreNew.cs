using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighscoreNew : MonoBehaviour
{
    movement_city script;

    [SerializeField] GameObject scoreObject;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI shadowScoreText;
    public TextMeshProUGUI highscoreText;

    private void Awake()
    {
        script = scoreObject.GetComponent<movement_city>();

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
        highscoreText.text = "0";
    }

    // Update is called once per frame
    void Update() 
    {
        scoreText.text = script.score.ToString();
        highscoreText.text = script.highscore.ToString();
    }
}
}