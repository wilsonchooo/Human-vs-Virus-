using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public float movespeed;
    float waittimer;
    public float waittomove;
    float attacktimer;
    public float waittoattack;
    bool walking;
    private GameObject target;
    float slowtimer;
    bool slowed;
    public int damage;
    Animator anim;
    float originalspeed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        walking = true;
        slowed = false;
        originalspeed =movespeed;
    }

    void Attack()
    {
        attacktimer += Time.deltaTime;

        if(attacktimer > waittoattack)
        {
            if (target != null)
            {
                anim.SetTrigger("Blob Attack");
                target.GetComponent<Towers>().health -= damage;
                attacktimer = 0;
            }



            else
            {
                walking = true;
                anim.ResetTrigger("Blob Attack");
            }
        }
        
    }
    // Update is called once per frame

    public void slow()
    {
        slowed = true;

    }
    void Update()
    {

        if(slowed==true)
        {
            movespeed = originalspeed / 2;
            slowtimer += Time.deltaTime;

            if (slowtimer >= 3)
            {
                movespeed = originalspeed;
                slowed = false;
                slowtimer = 0;
            }
        }


        waittimer += Time.deltaTime;
        if(waittimer>= waittomove)
        {

            if (walking)
            {
                anim.ResetTrigger("Blob Attack");
                transform.Translate(-Vector3.right * Time.deltaTime * movespeed, Space.World);

                if(this.gameObject.name =="Blue Slime(Clone)")
                {
                    anim.SetTrigger("Running");
                }
            }


            else Attack();
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            walking = false;

            target = collision.gameObject;
        }
    }
}
