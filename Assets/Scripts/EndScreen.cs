using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalscoreText;
    ScoreKeeper scoreKeeper;
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    public void ShowFinalScore()
    {
        finalscoreText.text = "Final Score " + scoreKeeper.CalculateScore();
    }
}
