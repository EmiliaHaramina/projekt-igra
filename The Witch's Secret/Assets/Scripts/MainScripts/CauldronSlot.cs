using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronSlot : MonoBehaviour
{
    public static int objectsInCauldron;
    public GameObject[] lines;
    public static bool doOnce;

    public static bool restartPosition;
    public static bool resOnce;
    public static List<string> objects = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        resOnce = false;
        restartPosition = false;
        doOnce = false;
        lines[0].SetActive(false);
        lines[1].SetActive(false);
        lines[2].SetActive(false);
        lines[3].SetActive(false);
        objectsInCauldron = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (objectsInCauldron == 0)
        {
            doOnce = false;
            resOnce = false;
            lines[0].SetActive(false);
            lines[1].SetActive(false);
            lines[2].SetActive(false);
            lines[3].SetActive(false);
        }
        else if (objectsInCauldron == 1)
        {
            lines[0].SetActive(true);
            lines[1].SetActive(false);
            lines[2].SetActive(false);
            lines[3].SetActive(false);
        }
        else if (objectsInCauldron == 2)
        {
            lines[0].SetActive(true);
            lines[1].SetActive(true);
            lines[2].SetActive(false);
            lines[3].SetActive(false);
        }
        else if (objectsInCauldron == 3)
        {
            lines[0].SetActive(true);
            lines[1].SetActive(true);
            lines[2].SetActive(true);
            lines[3].SetActive(false);
        }
        else if (objectsInCauldron == 4)
        {
            lines[0].SetActive(true);
            lines[1].SetActive(true);
            lines[2].SetActive(true);
            lines[3].SetActive(true);
            checkList();

        }
    }


    public void checkList()
    {
        foreach (string obj in objects)
        {
            if (!(objects.Contains("beer")))
            {
                if (doOnce == false)
                {

                    Debug.Log("WRONG COMBINATION");
                    GameObject.FindGameObjectWithTag("explosion").gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().Play("Explosion", -1, 0f);
                    Invoke("laterdis", 1.5f);
                    restartPosition = true;
                    doOnce = true;
                }
            }
        }
    }

    public void laterdis()
    {
        objectsInCauldron = 0;
        restartPosition = false;
    }

}
