using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcitvateBeginnerPanelOnMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        this.gameObject.transform.GetChild(3).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
