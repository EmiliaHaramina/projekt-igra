using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimOnNote : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OpenNote.glowingNote == true)
        {
            this.gameObject.GetComponent<Animator>().enabled = false;
        }
        else
        {
            this.gameObject.GetComponent<Animator>().enabled = true;
        }
    }
}
