using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("Score Settings")]
    public static int score = 0;
    [SerializeField] private int startingLives = 5;
    private int currentLives;

    [Header("UI References")]
    public Text scoreText;
    public Text livesText;

    private void Start()
    {
        ResetGame();
    }

    private void ResetGame()
    {
        score = 0;
        currentLives = startingLives;
        scoreText.text = "Score:" + score;
        livesText.text = "Lives : " + currentLives;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("XP"))
        {
            score += 1;
            scoreText.text = "Score:" + score;
            Destroy(other.gameObject);
        }
        
        else if (other.CompareTag("5XP"))
        {
            score += 5;
            scoreText.text = "Score:" + score;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("LOSS"))
        {
            currentLives--;
            livesText.text = "Lives : " + currentLives;

            if (currentLives <= 0)
            {
               
                SaveScore();
                SceneManager.LoadScene(3);
            }
        }
    }

    private void SaveScore()
    {
       
        int totalScore = PlayerPrefs.GetInt("TotalScore", 0);
       
        totalScore += score;
       
        PlayerPrefs.SetInt("TotalScore", totalScore);
        PlayerPrefs.Save();
    }
}