using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStopAnimSHowOutline : MonoBehaviour
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
        this.gameObject.GetComponent<Animator>().Play("EmptyBall");
        transform.GetComponent<SpriteRenderer>().sprite = outlinedSprite;

    }

    void OnMouseExit()
    {
        this.gameObject.GetComponent<Animator>().Play("CrystallBallAnimation", -1, 0f);
        transform.GetComponent<SpriteRenderer>().sprite = sprite;

    }


}
