using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOverNotebook : MonoBehaviour
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

    void OnMouseEnter()
    {
        if (OpenNote.noteOpened == false && Notebook.noteBookOpened == false)
        {
            this.gameObject.GetComponent<Animator>().Play("NotebookMove", -1, 0f);
            transform.GetComponent<SpriteRenderer>().sprite = outlinedSprite;
        }

    }

    void OnMouseExit()
    {
        this.gameObject.GetComponent<Animator>().Play("NotebookMoveReverse", -1, 0f);
        if (OpenNote.noteOpened == false && Notebook.noteBookOpened == false)
        {
            transform.GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }
}
