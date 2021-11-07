using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNote : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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
    }
}
