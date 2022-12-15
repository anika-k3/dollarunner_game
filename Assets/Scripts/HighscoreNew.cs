using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HighscoreNew : MonoBehaviour
{
    movement_city script;

    //GameObject scoreObject = GameObject.Find("score");

    public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI shadowScoreText;
    public TextMeshProUGUI highscoreText;

    //private void Awake()
    //{
    //    script = scoreObject.GetComponent<movement_city>();

    // Start is called before the first frame update

    [SerializeField] public int score = 0;
    [SerializeField] public int highscore = 0;
    [SerializeField] private int sceneID2;

    

    void Start()
    {
        // script = GameObject.Find("score").GetComponent<movement_city>();

    
        scoreText.text = "0";
        highscoreText.text = "0";
    }

    // Update is called once per frame
    void Update() 
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // If the player collides with a tag called Money, then the money disappears
        if (collision.gameObject.CompareTag("Money"))
        {
            Debug.Log("Collision");
            Destroy(collision.gameObject);
            score++;
            highscore++;
            scoreText.text = script.score.ToString();
            highscoreText.text = script.highscore.ToString();
            //highscoreText.IncrementHighscore(highscore);
        }
        // Sends the score to the console
        Debug.Log(score);
        // Sends the highscore to the console
        Debug.Log(highscore);

    
    }
}
