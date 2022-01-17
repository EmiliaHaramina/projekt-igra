using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonCong1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClosePaper()
    {
        CauldronSlot.congratulationsPlaying = false;
        //   SoundManagerScript.PlaySound("paper");
        OpenNote.glowingNote = false;
        OpenNote.noteOpened = false;
        PlayerPrefs.SetInt("Level", 2);
        GameObject.Find("CongratulationsCont1").gameObject.transform.GetChild(0).gameObject.SetActive(false);

    }
}