using UnityEngine;
using UnityEngine.UI;

public class MenUScore : MonoBehaviour
{
    public Text totalScoreText;

    private void Start()
    {
       
        int totalScore = PlayerPrefs.GetInt("TotalScore", 0);
      
        totalScoreText.text = "XP points: " + totalScore;
    }

   
    public void ResetTotalScore()
    {
        PlayerPrefs.SetInt("TotalScore", 0);
        PlayerPrefs.Save();
        totalScoreText.text = "XP points: 0";
    }
}