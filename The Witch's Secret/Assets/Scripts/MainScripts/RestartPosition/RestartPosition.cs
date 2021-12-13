using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPosition : MonoBehaviour
{
    private Vector2 originalPosGin, originalPosMandragora, originalPosBeer, originalPosHolly, originalPosAbsinthe, originalPosPeaches
    , originalPosWolfsbane, originalPosVodka, originalPosGarum, originalPosWormwood;
    public GameObject Mandragora;
    public GameObject Gin;
    public GameObject Beer;
    public GameObject Holly;
    public GameObject Absinthe;
    public GameObject Vodka;
    public GameObject Peaches;
    public GameObject Wolfsbane;
    public GameObject Garum;
    public GameObject Wormwood;

    // Start is called before the first frame update
    void Start()
    {
        originalPosGin = Gin.transform.position;
        originalPosMandragora = Mandragora.gameObject.transform.position;
        originalPosBeer = Beer.gameObject.transform.position;
        originalPosAbsinthe = Absinthe.gameObject.transform.position;
        originalPosVodka = Vodka.gameObject.transform.position;
        originalPosPeaches = Peaches.gameObject.transform.position;
        originalPosHolly = Holly.gameObject.transform.position;
        originalPosWolfsbane = Wolfsbane.gameObject.transform.position;
        originalPosGarum = Garum.gameObject.transform.position;
        originalPosWormwood = Wormwood.gameObject.transform.position;
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
                DragDropBeer.dragging = false;
                DragDropBeer.placed = false;
                DragDropVodka.dragging = false;
                DragDropVodka.placed = false;
                DragDropAbsinthe.dragging = false;
                DragDropAbsinthe.placed = false;
                DragDropPeaches.dragging = false;
                DragDropPeaches.placed = false;
                DragDropHolly.dragging = false;
                DragDropHolly.placed = false;
                DragDropWolfsbane.dragging = false;
                DragDropWolfsbane.placed = false;
                DragDropGarum.dragging = false;
                DragDropGarum.placed = false;
                DragDropWormwood.dragging = false;
                DragDropWormwood.placed = false;
                ///NAPISATI ZA SVE SKRIPTE
                Gin.gameObject.transform.position = originalPosGin;
                Mandragora.transform.position = originalPosMandragora;
                Beer.transform.position = originalPosBeer;
                Vodka.transform.position = originalPosVodka;
                Wolfsbane.transform.position = originalPosWolfsbane;
                Absinthe.transform.position = originalPosAbsinthe;
                Holly.transform.position = originalPosHolly;
                Peaches.transform.position = originalPosPeaches;
                Garum.transform.position = originalPosGarum;
                Wormwood.transform.position = originalPosWormwood;
                CauldronSlot.resOnce = true;
            }
        }
    }


}
