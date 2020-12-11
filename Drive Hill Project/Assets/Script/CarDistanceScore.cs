using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class CarDistanceScore : MonoBehaviour
{
    // checkpoint
    [SerializeField]
    private Transform start;

    // UI yang menunjukkan distance
    [SerializeField]
    private Text scoreText;

    // kalkukasi distance
    private float distance;

    private void Update()
    {

        // Calculate distance value by X axis
        distance = (transform.position.x - start.transform.position.x);

        // distance.ToString(F1) for float
        scoreText.text = "Score  " + ((int)distance).ToString() + " m";

    }

    public GameObject deathMenuUI;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "DeadTrigger")
        {
            deathMenuUI.SetActive(true);
            Time.timeScale = 0f;
            AudioListener.pause = true;
        }
    }
}
