using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkayButton : MonoBehaviour
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
        SoundManagerScript.PlaySound("paper");
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(1).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(2).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(3).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(4).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(5).gameObject.SetActive(false);
        OpenNote.noteOpened = false;
    }
}
