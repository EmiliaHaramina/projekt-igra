using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
}
