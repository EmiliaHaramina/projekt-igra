using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropGin : MonoBehaviour
{

    public static bool dragging, placed;
    private Camera cam;
    private Vector2 offset, originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }
    void Awake()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (placed) return;
        if (!dragging) return;
        Vector2 mousePosition = new Vector3();
        mousePosition = GetMousePos();
        transform.position = mousePosition - offset;
    }

    void OnMouseDown()
    {
        if (OpenNote.noteOpened == false && Notebook.noteBookOpened == false)
        {

            dragging = true;
            offset = GetMousePos() - (Vector2)transform.position;

        }

    }

    void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("cauldron").gameObject.transform.position) < 2)
        {
            SoundManagerScript.PlaySound("addIngredient");
            SoundManagerScript.PlaySound("alcoholicDrink");
            transform.position = GameObject.FindGameObjectWithTag("slot").gameObject.transform.position;
            placed = true;
            CauldronSlot.objectsInCauldron++;
            GameObject.FindGameObjectWithTag("cauldron").gameObject.GetComponent<Animator>().Play("ObjectDrop", -1, 0f);
            CauldronSlot.objects.Add("gin");
        }
        else
        {
            transform.position = originalPosition;
            dragging = false;
        }
    }

    Vector2 GetMousePos()
    {
        return cam.ScreenToWorldPoint(Input.mousePosition);
    }

    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }


}
