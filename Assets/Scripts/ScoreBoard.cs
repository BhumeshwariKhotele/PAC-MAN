using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreBoard : MonoBehaviour
{
    public Text ScoreText;

    public int score;
    public void IncrementScore()
    {
        score=score+5;
        ScoreText.text = "Score: " + score;

    }
}



