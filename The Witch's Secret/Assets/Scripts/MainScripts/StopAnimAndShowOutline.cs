using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimAndShowOutline : MonoBehaviour
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
        this.gameObject.GetComponent<Animator>().Play("Empty");
        transform.GetComponent<SpriteRenderer>().sprite = outlinedSprite;

    }

    void OnMouseExit()
    {
        this.gameObject.GetComponent<Animator>().Play("SmallPaperGlow");
        transform.GetComponent<SpriteRenderer>().sprite = sprite;

    }


}
