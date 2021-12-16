using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchClockSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if (OpenNote.noteOpened == false && Notebook.noteBookOpened == false) //OpenCrystallBall.ballOpened?
        SoundManagerScript.PlaySound("clock");
    }    
}
