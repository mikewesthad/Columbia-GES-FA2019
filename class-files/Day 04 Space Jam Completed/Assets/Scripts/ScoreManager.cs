using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int score = 0;

    void OnTriggerEnter(Collider other)
    {
        score += 1;
        Debug.Log("Score: " + score);
        scoreText.text = "Score: " + score;
    }
}
