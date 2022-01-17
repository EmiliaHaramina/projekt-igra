using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMusicMenu : MonoBehaviour
{
    void Start()
    {

    }
    // Start is called before the first frame update
    void Awake()
    {
        if (PlayerPrefs.GetInt("Music") == 1)
        {
            this.gameObject.GetComponent<AudioSource>().mute = true;
        }
        else if (PlayerPrefs.GetInt("Music") == 0)
        {

            this.gameObject.GetComponent<AudioSource>().mute = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Music") == 1)
        {
            this.gameObject.GetComponent<AudioSource>().mute = true;
        }
        else if (PlayerPrefs.GetInt("Music") == 0)
        {
            this.gameObject.GetComponent<AudioSource>().mute = false;
        }
    }
}

