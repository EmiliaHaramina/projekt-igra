using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronSlot : MonoBehaviour
{
    public static int objectsInCauldron;
    public GameObject[] lines;
    // Start is called before the first frame update
    void Start()
    {
        lines[0].SetActive(false);
        lines[1].SetActive(false);
        lines[2].SetActive(false);
        lines[3].SetActive(false);
        objectsInCauldron = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (objectsInCauldron == 0)
        {
            lines[0].SetActive(false);
            lines[1].SetActive(false);
            lines[2].SetActive(false);
            lines[3].SetActive(false);
        }
        else if (objectsInCauldron == 1)
        {
            lines[0].SetActive(true);
            lines[1].SetActive(false);
            lines[2].SetActive(false);
            lines[3].SetActive(false);
        }
        else if (objectsInCauldron == 2)
        {
            lines[0].SetActive(true);
            lines[1].SetActive(true);
            lines[2].SetActive(false);
            lines[3].SetActive(false);
        }
        else if (objectsInCauldron == 3)
        {
            lines[0].SetActive(true);
            lines[1].SetActive(true);
            lines[2].SetActive(true);
            lines[3].SetActive(false);
        }
        else if (objectsInCauldron == 4)
        {
            lines[0].SetActive(true);
            lines[1].SetActive(true);
            lines[2].SetActive(true);
            lines[3].SetActive(true);
        }
    }
}
