using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButton : MonoBehaviour
{
    public GameObject objects;
    private static bool xPressable;
    // Start is called before the first frame update
    void Start()
    {
        xPressable = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void xPress()
    {
        if (xPressable == true)
        {
            GameObject.FindGameObjectWithTag("fade").gameObject.GetComponent<Animator>().Play("FadeInsideBallReverse", -1, 0f);
            Invoke("returnBall", 1f);
            xPressable = false;
        }

    }

    public void returnBall()
    {
        GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<Animator>().Play("GoIntoBallReverse", -1, 0f);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(1).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(2).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(3).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(4).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(5).gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(6).gameObject.SetActive(false);
        objects.gameObject.SetActive(true);
        Invoke("laterInvokex", 5f);

    }

    public void laterInvokex()
    {
        xPressable = true;
    }

}
