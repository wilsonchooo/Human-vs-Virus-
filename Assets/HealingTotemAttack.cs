using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingTotemAttack : MonoBehaviour
{
    public float damage;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        timer = 0;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            timer += Time.deltaTime;

                if(timer>=.5f)
                {
                    collision.gameObject.GetComponent<Enemy>().life -= damage;
                    Debug.Log("dealing damage");
                    Debug.Log(collision.gameObject.GetComponent<Enemy>().life);
                    timer = 0;
                }

            

        }
    }
}
