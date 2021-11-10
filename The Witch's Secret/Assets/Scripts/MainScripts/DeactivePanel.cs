using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivePanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("deactivateThisPanel", 1.1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void deactivateThisPanel()
    {
        this.gameObject.SetActive(false);
    }
}
