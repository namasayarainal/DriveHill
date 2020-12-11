using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class DeadTriggerScript : MonoBehaviour
{
    public GameObject deathMenuUI;
    public Text scoreText;

    void Start()
    {
        deathMenuUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "DeadTrigger")
        {
            deathMenuUI.SetActive(true);
            Time.timeScale = 0f;
            AudioListener.pause = true;
        }  
    }
    
    public void UpdateScore(int distance)
    {
        deathMenuUI.SetActive(true);
        scoreText.text = distance.ToString();
    }
}
