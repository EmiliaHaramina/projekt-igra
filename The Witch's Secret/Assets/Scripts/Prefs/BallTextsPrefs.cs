using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTextsPrefs : MonoBehaviour
{
    public GameObject[] levelTexts;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Level") == 1)
        {
            levelTexts[0].gameObject.SetActive(true);
            levelTexts[1].gameObject.SetActive(false);
            levelTexts[2].gameObject.SetActive(false);
            levelTexts[3].gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Level") == 2)
        {
            levelTexts[0].gameObject.SetActive(false);
            levelTexts[1].gameObject.SetActive(true);
            levelTexts[2].gameObject.SetActive(false);
            levelTexts[3].gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Level") == 3)
        {
            levelTexts[0].gameObject.SetActive(false);
            levelTexts[1].gameObject.SetActive(false);
            levelTexts[2].gameObject.SetActive(true);
            levelTexts[3].gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Level") == 4)
        {
            levelTexts[0].gameObject.SetActive(false);
            levelTexts[1].gameObject.SetActive(false);
            levelTexts[2].gameObject.SetActive(false);
            levelTexts[3].gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Level") == 5)
        {
            levelTexts[0].gameObject.SetActive(false);
            levelTexts[1].gameObject.SetActive(false);
            levelTexts[2].gameObject.SetActive(false);
            levelTexts[3].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Level") == 1)
        {
            levelTexts[0].gameObject.SetActive(true);
            levelTexts[1].gameObject.SetActive(false);
            levelTexts[2].gameObject.SetActive(false);
            levelTexts[3].gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Level") == 2)
        {
            levelTexts[0].gameObject.SetActive(false);
            levelTexts[1].gameObject.SetActive(true);
            levelTexts[2].gameObject.SetActive(false);
            levelTexts[3].gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Level") == 3)
        {
            levelTexts[0].gameObject.SetActive(false);
            levelTexts[1].gameObject.SetActive(false);
            levelTexts[2].gameObject.SetActive(true);
            levelTexts[3].gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Level") == 4)
        {
            levelTexts[0].gameObject.SetActive(false);
            levelTexts[1].gameObject.SetActive(false);
            levelTexts[2].gameObject.SetActive(false);
            levelTexts[3].gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Level") == 5)
        {
            levelTexts[0].gameObject.SetActive(false);
            levelTexts[1].gameObject.SetActive(false);
            levelTexts[2].gameObject.SetActive(false);
            levelTexts[3].gameObject.SetActive(true);
        }
    }
}
