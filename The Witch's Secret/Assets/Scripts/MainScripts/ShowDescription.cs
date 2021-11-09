using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDescription : MonoBehaviour
{
    public GameObject description;
    public static bool clickedObject;

    // Start is called before the first frame update
    void Start()
    {
        clickedObject = false;
        description.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseOver()
    {

        if (clickedObject == false)
        {
            if (OpenNote.noteOpened == false)
            {

                description.SetActive(true);
            }
        }
        else
        {
            description.SetActive(false);
        }
    }
    void OnMouseExit()
    {
        description.SetActive(false);
    }

    void OnMouseDown()
    {
        clickedObject = true;
        description.SetActive(false);
    }

    void OnMouseUp()
    {
        Invoke("laterClik", 0.5f);
        if (description.activeInHierarchy)
        {
            description.SetActive(false);
        }
    }

    public void laterClik()
    {
        clickedObject = false;
    }





}
