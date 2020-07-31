using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] spawnpoints;
    public GameObject[] enemies;
    
    public int[] numberperwave;
    private int wave;
    float timer;
    public float spawned;
    private GameObject waveText;

    GameObject WaveButton;
    void Start()
    {
        waveText = GameObject.FindGameObjectWithTag("waveText");
        WaveButton = GameObject.FindGameObjectWithTag("Next Wave");
        spawnpoints = GameObject.FindGameObjectsWithTag("Spawner");
        WaveButton.SetActive(false);


        foreach (GameObject g in spawnpoints)
        {
            Debug.Log(g.name);
        }

        for (int i = 10; i < spawnpoints.Length; i++)
        {
            spawnpoints[i] = spawnpoints[wave * 20];
        }


    }


    public void nextwave()
    {
        if (wave < numberperwave.Length-1)
        {
            wave++;
            spawned = 0;
            waveText.GetComponent<Text>().text= "Wave" + wave.ToString();
        }

        else Debug.Log("no more waves");
    }

    void spawn()
    {
        //GameObject spawnedenemy;
        int randomspawnpoint = Random.Range(0, spawnpoints.Length);
        int randomenemy = Random.Range(0, enemies.Length);
        //Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
        switch (wave)
        {
            case 0:
                Instantiate(enemies[0], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                
                break;
            case 1: 
                randomenemy = Random.Range(0, 2);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;
            case 2:
                randomenemy = Random.Range(0, 2);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;
            case 3:
                randomenemy = Random.Range(0, 3);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;
            case 4:
                randomenemy = Random.Range(0, 3);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;
            case 5:
                randomenemy = Random.Range(0, 4);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;
            case 6:
                randomenemy = Random.Range(0, 5);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;

            case 7:
                randomenemy = Random.Range(0, 6);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;
            case 8:
                randomenemy = Random.Range(0, 6);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;
            case 9:
                randomenemy = Random.Range(0, 6);
                Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                break;
            default:
                randomenemy = Random.Range(0, 6);
                GameObject spawnedenemy = Instantiate(enemies[randomenemy], spawnpoints[randomspawnpoint].transform.position, Quaternion.identity);
                spawnedenemy.GetComponent<Enemy>().life += wave;
                break;
        }

    }

    private float spawntime()
    {
        switch(wave)
        {
            case 0: return 2.5f;
            case 1: return 2;
            case 2: return 1.7f;
            case 3: return 1.6f;
            case 4: return 1.5f;
            case 5: return 1.4f;
            case 6: return 1.3f;
            case 7: return 1.2f;
            case 8: return 1;
            case 9: return .9f;

            default: return .2f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(spawned >= numberperwave[wave])
        {
            //Debug.Log("kills needed for next wave");
            if(GameObject.FindGameObjectsWithTag("enemy").Length < 1 )
            {
                WaveButton.SetActive(true);
            }

            
        }


        else if(timer>= spawntime())
        {
            //WaveButton.SetActive(false);
            spawn();
            spawned++;
            timer = 0;
        }

    }
}
