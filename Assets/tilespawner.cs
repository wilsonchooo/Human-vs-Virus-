using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilespawner : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    public GameObject[] enemy;
    void Start()
    {
        foreach (GameObject g in enemy)
        {
            //Instantiate(g, transform.position,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer>=3)
        {
            int mob = Random.Range(0, enemy.Length);
            int spawnchance = Random.Range(0, 10);

            if(spawnchance>3)
            Instantiate(enemy[mob], transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
