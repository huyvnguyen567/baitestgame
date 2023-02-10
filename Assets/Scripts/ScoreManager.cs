using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int score = 0;
   
    public void ModifyScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score.ToString();
    }
}
