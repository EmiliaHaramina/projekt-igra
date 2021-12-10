using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(5).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
