using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttons : MonoBehaviour
{

    public GameObject hands;
    public GameObject home;
    public GameObject cough;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void washhands()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        Instantiate(hands, new Vector3(0, 0), Quaternion.identity);
        foreach (GameObject g in enemies)
        {
            Destroy(g.gameObject);
        }

        this.GetComponent<Image>().enabled = false;
        this.GetComponent<Button>().enabled = false;
    }

    public void stayathome()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        Instantiate(home, new Vector3(0, 0), Quaternion.identity);
        foreach (GameObject g in enemies)
        {
            Destroy(g.gameObject);
        }

        this.GetComponent<Image>().enabled = false;
        this.GetComponent<Button>().enabled = false;
    }


    public void covercough()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        Instantiate(cough, new Vector3(0, 0), Quaternion.identity);
        foreach (GameObject g in enemies)
        {
            Destroy(g.gameObject);
        }

        this.GetComponent<Image>().enabled = false;
        this.GetComponent<Button>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
