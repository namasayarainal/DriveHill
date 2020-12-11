using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSound : MonoBehaviour
{
    public AudioSource someSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            someSound.Play();
        }

        if(Input.GetKeyUp(KeyCode.D))
        {
            someSound.Stop();
        }
    }
}
