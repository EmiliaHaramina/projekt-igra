using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPosition : MonoBehaviour
{
    private Vector2 originalPosGin, originalPosMandragora;
    public GameObject Mandragora;
    public GameObject Gin;

    // Start is called before the first frame update
    void Start()
    {
        originalPosGin = transform.position;
        originalPosMandragora = Mandragora.gameObject.transform.position;
    }
    void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (CauldronSlot.restartPosition == true)
        {
            if (CauldronSlot.resOnce == false)
            {
                ///NAPISATI ZA SVE SKRIPTE
                DragDropGin.dragging = false;
                DragDropGin.placed = false;
                DragDropMandragora.dragging = false;
                DragDropMandragora.placed = false;
                ///NAPISATI ZA SVE SKRIPTE
                Gin.gameObject.transform.position = originalPosGin;
                Mandragora.transform.position = originalPosMandragora;
                CauldronSlot.resOnce = true;
            }
        }
    }


}
