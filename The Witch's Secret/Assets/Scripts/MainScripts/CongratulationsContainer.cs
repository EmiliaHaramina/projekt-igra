using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratulationsContainer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("laterShowNote", 1.5f);
    }

    public void laterShowNote()
    {
        this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        this.gameObject.transform.GetChild(2).gameObject.SetActive(true);
        Invoke("laterShowNote2", 4f);
    }

    public void laterShowNote2()
    {
        this.gameObject.transform.GetChild(3).gameObject.SetActive(true);
    }
}
