using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCrystallBall : MonoBehaviour
{
    public static bool canOpenBall;
    // Start is called before the first frame update
    void Start()
    {
        canOpenBall = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openBall()
    {
        if (OpenNote.noteOpened == false && Notebook.noteBookOpened == false && canOpenBall == false)
        {
            canOpenBall = true;
            //Jakov
            SoundManagerScript.PlaySound("mysticBall");
            //

            GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<Animator>().Play("GoIntoBall", -1, 0f);
            Invoke("laterInvokeBall", 2f);

        }
    }

    public void laterInvokeBall()
    {
        canOpenBall = false;
        GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<Animator>().Play("New State", -1, 0f);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("fade").gameObject.GetComponent<Animator>().Play("FadeInsideBall", -1, 0f);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(1).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(2).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(3).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(4).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(5).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("ball").gameObject.transform.GetChild(6).gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("objects").gameObject.SetActive(false);
        //   GameObject.FindGameObjectWithTag("objects").gameObject.transform.GetChild(10).gameObject.SetActive(true);

    }
}
