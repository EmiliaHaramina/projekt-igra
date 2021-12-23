using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronSlot : MonoBehaviour
{
    public static bool congratulationsPlaying;
    public static int objectsInCauldron;
    public GameObject[] lines;
    private bool oneSound;
    public static bool doOnce;

    public static bool restartPosition;
    public static bool resOnce;
    public GameObject lovePotion;
    public GameObject successPrefab;
    public static bool unlockedPotion1;
    public static List<string> objects = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        congratulationsPlaying = false;
        oneSound = false;
        unlockedPotion1 = false;
        lovePotion.SetActive(false);
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
            //  if (PlayerPrefs.GetInt("Level") == 1)
            //  {
            if (!(objects.Contains("garum")) || !(objects.Contains("vodka")) || !(objects.Contains("holly")) || !(objects.Contains("peaches")))
            {
                if (doOnce == false)
                {

                    Debug.Log("WRONG COMBINATION");
                    SoundManagerScript.PlaySound("wrongIngredients");
                    GameObject.Find("Cauldron").gameObject.GetComponent<Animator>().Play("Success");
                    Invoke("laterExplode", 2f);
                    Invoke("laterdis", 1.2f);
                    restartPosition = true;
                    doOnce = true;
                }
            }
            else
            {
                if (doOnce == false)
                {
                    if (!oneSound)
                    {
                        SoundManagerScript.PlaySound("correctIngredients");
                        oneSound = true;
                    }
                    congratulationsPlaying = true;
                    Debug.Log("SUCESS");
                    GameObject.Find("Cauldron").gameObject.GetComponent<Animator>().Play("Success");
                    Invoke("beforeLater", 1f);
                }
            }
            //   }

        }
    }

    public void laterdis()
    {
        objects.Clear();
        objectsInCauldron = 0;
        restartPosition = false;
    }

    public void beforeLater()
    {
        GameObject.Find("CongratulationsCont1").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        OpenNote.noteOpened = true;
        lovePotion.SetActive(true);
        Invoke("laterdis", 1.2f);
        restartPosition = true;
        doOnce = true;
        oneSound = false;
    }

    public void beforeBefore()
    {

    }

    public void laterExplode()
    {
        GameObject.FindGameObjectWithTag("explosion").gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().Play("Explosion", -1, 0f);
    }

}
