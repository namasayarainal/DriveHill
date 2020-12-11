using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    private const string highScoreKey = "HighScore";

    [SerializeField] private int currentScore;

    public Text currentScoreText;

    [Header("Score values")] [SerializeField] private int highScore;

    public Text highScoreText;

    public Transform player;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        highScoreText.text = "BEST : " + highScore.ToString() + " m";
        PlayerPrefs.Save();
    }

    private void Update()
    {
        currentScore = Mathf.RoundToInt(player.position.x);
        currentScoreText.text = "Distance " + currentScore.ToString() + " m";

        if (currentScore > highScore)
        {
            highScore = currentScore;
            highScoreText.text = "BEST : " + highScore.ToString() + " m";
            PlayerPrefs.SetInt(highScoreKey, highScore);
        }
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        Debug.Log("The high score is currently: " + highScore);
    }
}
