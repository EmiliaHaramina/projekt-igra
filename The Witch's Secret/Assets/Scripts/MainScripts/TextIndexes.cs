using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextIndexes : MonoBehaviour
{
    public static int activeIndex;
    public GameObject[] texts;
    // Start is called before the first frame update
    void Start()
    {
        activeIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeIndex == 0)
        {
            texts[0].SetActive(true);
            texts[1].SetActive(false);
            texts[2].SetActive(false);

        }
        else if (activeIndex == 1)
        {
            texts[0].SetActive(false);
            texts[1].SetActive(true);
            texts[2].SetActive(false);
        }
        else if (activeIndex == 2)
        {
            texts[0].SetActive(false);
            texts[1].SetActive(false);
            texts[2].SetActive(true);
        }
    }
}
