using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowOutlineViaAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Animator>().Play("Outline");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Animator>().Play("WithoutOutline");
    }
}
