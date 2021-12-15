using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOutline : MonoBehaviour
{
    public Sprite sprite;
    public Sprite outlinedSprite;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (OpenNote.noteOpened == false && Notebook.noteBookOpened == false)
        {
            transform.GetComponent<SpriteRenderer>().sprite = outlinedSprite;
        }

    }

    void OnMouseExit()
    {
        if (OpenNote.noteOpened == false && Notebook.noteBookOpened == false)
        {
            transform.GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }
}
