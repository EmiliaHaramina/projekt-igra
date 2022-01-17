using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedLovePotion : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Level") == 2 || PlayerPrefs.GetInt("Level") == 3 || PlayerPrefs.GetInt("Level") == 4 || PlayerPrefs.GetInt("Level") == 5)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Level") == 2 || PlayerPrefs.GetInt("Level") == 3 || PlayerPrefs.GetInt("Level") == 4 || PlayerPrefs.GetInt("Level") == 5)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
