using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyan_Slime_Attack : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject target;


    public int damage;
    Animator anim;
    bool walking;
    public float movespeed;
    float timer;
    void Start()
    {
        anim = GetComponent<Animator>();
        walking = true;
   
    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer>=5)
        {
            anim.SetTrigger("Running");
            transform.Translate(-Vector3.right * Time.deltaTime * movespeed, Space.World);
        }



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            walking = false;

            target = collision.gameObject;
            target.GetComponent<Towers>().health -= damage;
            Destroy(this.gameObject);
        }
    }
}
