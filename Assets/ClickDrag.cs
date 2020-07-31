using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDrag : MonoBehaviour
{
    public LayerMask draggableMask;
    public LayerMask dropSpotsMask;
    private GameObject gm;
    public GameObject itself;
    GameObject selectedObject;
    bool isDragging;
    bool spawned;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        isDragging = false;
        gm = GameObject.FindGameObjectWithTag("gm");
        spawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, draggableMask);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                selectedObject = hit.collider.gameObject;
                offset = hit.collider.gameObject.transform.position - ray.origin;
                isDragging = true;
            }
        }

        if (isDragging)
        {
            Vector3 pos = mousePos();
            selectedObject.transform.position = pos + offset;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;

            CheckForDrop();

        }
    }

    Vector3 mousePos()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
    }


    void CheckForDrop()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, dropSpotsMask);
        if (hit.collider != null)
        {
            if (selectedObject != null)
            {
                    //if (gm.GetComponent<UI>().currency > GetComponent<Towers>().price)
                //{
                    //gm.GetComponent<UI>().currency -= GetComponent<Towers>().price;
                    selectedObject.transform.position = hit.collider.gameObject.transform.position;
                    selectedObject.layer = LayerMask.NameToLayer("Ignore Raycast");
                    selectedObject = null;
                //}
            }


        }
    }
}