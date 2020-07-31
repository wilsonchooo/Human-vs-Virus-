using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float life;
    public int pointvalue;
    private GameObject currencyUI;
    GameObject spawner;
    GameObject [] enemies;
    void Start()
    {
        currencyUI = GameObject.FindGameObjectWithTag("CurrencyUI");
        spawner = GameObject.FindGameObjectWithTag("Enemy Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(life<=0)
        {

            if(this.gameObject.name == "big slime(Clone)" || this.gameObject.name == "medium slime(Clone)")
            {
                GameObject spawnlocation = this.transform.Find("big slime spawn").gameObject;
                enemies = GameObject.FindGameObjectWithTag("Enemy Spawner").GetComponent<EnemySpawner>().enemies;


                for (int i = 0; i < enemies.Length-2; i++)
                {
                    Instantiate(enemies[i], spawnlocation.transform.position, Quaternion.identity);
                    Instantiate(enemies[i], spawnlocation.transform.position, Quaternion.identity);
                    Instantiate(enemies[i], spawnlocation.transform.position, Quaternion.identity);
                    Instantiate(enemies[i], spawnlocation.transform.position, Quaternion.identity);
                }

                
            }
            //currencyUI.GetComponent<UI>().changecurrency(pointvalue);
            //spawner.GetComponent<EnemySpawner>().++;
            //Debug.Log(spawner.GetComponent<EnemySpawner>().kills);

            Destroy(this.gameObject);

        }
    }
}
