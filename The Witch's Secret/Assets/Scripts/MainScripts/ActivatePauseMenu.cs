using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePauseMenu : MonoBehaviour
{
    public static bool pauseGameOnce;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (!pauseGameOnce)
            {
                pauseGameOnce = true;
                GameObject.FindGameObjectWithTag("mainCanvas").gameObject.transform.GetChild(2).gameObject.SetActive(false);
                GameObject.Find("PauseMenu").transform.GetChild(0).gameObject.SetActive(true);
                GameObject.Find("PauseMenu").transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }
}
