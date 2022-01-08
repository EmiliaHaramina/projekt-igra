using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBeginnerPanelOnMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        this.gameObject.transform.GetChild(8).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
