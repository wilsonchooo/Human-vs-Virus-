using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTile : MonoBehaviour
{
    // Start is called before the first frame update
    public bool taken;
    public GameObject occupied;
    void Start()
    {
        taken = false;
    }

    public void setTotem(GameObject totem)
    {
        occupied = totem;
        taken = true;

        totem.GetComponent<Towers>().setTile(this.gameObject);
    }
    public bool available()
    {
        return taken;
    }

    public void Reset()
    {
        taken = false;
        occupied = null;
    

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
