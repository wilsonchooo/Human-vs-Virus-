using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveButton : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject spawner;
    void Start()
    {

    }

    public void changewave()
    {


        spawner = GameObject.FindGameObjectWithTag("Enemy Spawner");
        spawner.GetComponent<EnemySpawner>().nextwave();
        this.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
