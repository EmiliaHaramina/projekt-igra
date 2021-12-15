using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableNotebook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.GetChild(5).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
