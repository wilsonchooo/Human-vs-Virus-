using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float DistanceLimit;
    private float distance;

    public int form;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Time.deltaTime*speed, transform.position.y, 0);
        distance += Time.deltaTime * speed;
        if(distance > DistanceLimit)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            if(form ==0)
            {
                collision.gameObject.GetComponent<Enemy>().life -= 3;
                Destroy(this.gameObject);
            }

            if(form ==1)
            {
                collision.gameObject.GetComponent<Enemy>().life -= 3;
                collision.gameObject.GetComponent<enemymovement>().slow();
                Destroy(this.gameObject);
            }

        }
    }
}
