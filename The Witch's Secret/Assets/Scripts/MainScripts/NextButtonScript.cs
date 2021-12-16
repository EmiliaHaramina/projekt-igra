using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nextPress()
    {
        SoundManagerScript.PlaySound("paper");
        if (TextIndexes.activeIndex < 2)
        {
            TextIndexes.activeIndex++;
        }
        else if (TextIndexes.activeIndex == 2)
        {
            TextIndexes.activeIndex = 0;
        }
    }
}
