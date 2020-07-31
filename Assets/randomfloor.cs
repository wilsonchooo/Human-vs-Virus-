using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomfloor : MonoBehaviour
{

    public Sprite[] floors;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = floors[Random.Range(0, floors.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
