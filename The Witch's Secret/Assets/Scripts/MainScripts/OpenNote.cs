using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNote : MonoBehaviour
{
    public static bool noteOpened;
    public static bool glowingNote; //Pretvoriti u player prefs
    // Start is called before the first frame update
    void Start()
    {
        glowingNote = false;
        noteOpened = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenPaper()
    {
        if (CauldronSlot.congratulationsPlaying == false)
        {
            SoundManagerScript.PlaySound("paper");
            glowingNote = true;
            GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(1).gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(2).gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(3).gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(4).gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(5).gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(2).gameObject.GetComponent<Animator>().Play("WithoutOutline");
            GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(4).gameObject.GetComponent<Animator>().Play("WithoutOutline");

            noteOpened = true;
        }

    }
}
