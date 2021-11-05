using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDescription : MonoBehaviour
{
    public GameObject description;
    private int numOfClicks;
    // Start is called before the first frame update
    void Start()
    {
        numOfClicks = 0;
        description.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        if (numOfClicks == 0)
        {
            description.SetActive(true);
            numOfClicks++;
        }
        else if (numOfClicks == 1)
        {
            description.SetActive(false);
            numOfClicks = 0;
        }
    }






}
