using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whitebloodcell : MonoBehaviour
{

    public GameObject location;
    float movetime = 1f;
    bool moving;
    private GameObject currencyUI;
    void Start()
    {
        currencyUI = GameObject.FindGameObjectWithTag("CurrencyUI");

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "White Blood Cell")
                {
                    Debug.Log("wbc been clicked ");
                    moving = true;
                    currencyUI.GetComponent<UI>().changecurrency(1);
                }
            }

        }


        if (moving)
        {
            transform.position = Vector3.Lerp(transform.position, location.transform.position, Time.deltaTime/movetime);

            if (transform.position == location.transform.position)
            {

                Destroy(this.gameObject);
            }

            
        }
    }
}
