using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBookPreds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("NewGameButtonPressed") == 1)
        {
            this.gameObject.GetComponent<InputField>().text = "...";
            PlayerPrefs.SetInt("NewGameButtonPressed", 0);
        }
        else
        {
            this.gameObject.GetComponent<InputField>().text = PlayerPrefs.GetString("book");
        }

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("book", this.gameObject.GetComponent<InputField>().text);
    }
}
