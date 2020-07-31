using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    public LayerMask draggableMask;
    public LayerMask dropSpotsMask;
    private GameObject gm;
    GameObject selectedObject;
    public bool dropped;
    Vector3 offset;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gm");
        dropped = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = mousePos();
        if(!dropped)
        transform.position = pos + offset;

        if (Input.GetMouseButtonUp(0))
        {
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
        if (hit.collider != null && dropped==false)
        {
            if (hit.collider.gameObject.tag == "drop")
            {
                GameObject tile = hit.collider.gameObject;
                if(tile.GetComponent<PlaceTile>().taken ==false)
                {
                        tile.gameObject.GetComponent<PlaceTile>().setTotem(this.gameObject);
                        transform.position = hit.collider.gameObject.transform.position;
                        this.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
                        dropped = true;
                        anim.SetTrigger("ToIdle");
                }

                else if(tile.GetComponent<PlaceTile>().occupied.gameObject.name == this.gameObject.name)
                    {
                        if (tile.GetComponent<PlaceTile>().occupied.gameObject.GetComponent<Towers>().form!=2)
                        {
                            Debug.Log("same name detected");
                            tile.GetComponent<PlaceTile>().occupied.gameObject.GetComponent<Towers>().changeform(1);
                            Destroy(this.gameObject);
                        }

                    }
            }
        }
    }
}