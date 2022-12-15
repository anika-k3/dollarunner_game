using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GMScript : MonoBehaviour
{
    [HideInInspector]
    public int GameScore = 0;
    public Text ScoreText;
    public Text ShadowScoreText;

    private void Start()
    {
        GameScore = 0;
        
    }

    private void Update()
    {
        ScoreText.text = "Score:" + GameScore;
        ShadowScoreText.text = "Score:" + GameScore;
    }







}
