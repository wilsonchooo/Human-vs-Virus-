using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bone : MonoBehaviour
{
    public GameObject whitebloodcell;
    float timer;
    GameObject WaveButton;

    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>6)
        {
            WaveButton = GameObject.FindGameObjectWithTag("Next Wave");

            enemies = GameObject.FindGameObjectsWithTag("enemy");

            if(enemies.Length>=1)
            {
                if (GetComponent<Towers>().form == 0)
                {
                       Instantiate(whitebloodcell, transform.position, Quaternion.identity);
                    
                }


                else if (GetComponent<Towers>().form == 1)
                {
                    Instantiate(whitebloodcell, transform.position, Quaternion.identity);

                }

                else if (GetComponent<Towers>().form == 2)
                {
                    Instantiate(whitebloodcell, transform.position, Quaternion.identity);
                    Instantiate(whitebloodcell, transform.position, Quaternion.identity);
                }
            }


            timer = 0;
        }

    }
}
