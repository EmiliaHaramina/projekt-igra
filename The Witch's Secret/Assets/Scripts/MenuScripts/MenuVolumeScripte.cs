using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuVolumeScripte : MonoBehaviour
{
    public GameObject musicOn, sfxOn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void mButtonPress()
    {
        if (PlayerPrefs.GetInt("Music") == 0)
        {
            musicOn.gameObject.GetComponent<Text>().text = "Off";
            PlayerPrefs.SetInt("Music", 1);
        }
        else if (PlayerPrefs.GetInt("Music") == 1)
        {
            musicOn.gameObject.GetComponent<Text>().text = "On";
            PlayerPrefs.SetInt("Music", 0);
        }
    }

    public void sButtonPress()
    {
        if (PlayerPrefs.GetInt("SFX") == 0)
        {
            sfxOn.gameObject.GetComponent<Text>().text = "Off";
            PlayerPrefs.SetInt("SFX", 1);
        }
        else if (PlayerPrefs.GetInt("SFX") == 1)
        {
            sfxOn.gameObject.GetComponent<Text>().text = "On";
            PlayerPrefs.SetInt("SFX", 0);
        }
    }

}
