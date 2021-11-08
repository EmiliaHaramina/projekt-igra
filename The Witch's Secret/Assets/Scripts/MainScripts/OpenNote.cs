using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNote : MonoBehaviour
{
    public static bool noteOpened;
    // Start is called before the first frame update
    void Start()
    {
        noteOpened = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenPaper()
    {
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(1).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(2).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(3).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(4).gameObject.SetActive(true);
        noteOpened = true;

    }
}
