using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerattack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    float timer;
    bool dropped;
    public GameObject detectionsquare;
    Animator anim;

    public float attackspeed;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void fire()
    {
        int form = GetComponent<Towers>().returnform();
        switch(form)
        {
            case 0:
                Instantiate(projectile, transform.position, Quaternion.identity);
                break;
            case 1:
                Instantiate(projectile, transform.position, Quaternion.identity);
                Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z), Quaternion.identity);
                break;
            case 2:
                Instantiate(projectile, new Vector3(transform.position.x+.3f, transform.position.y, transform.position.z), Quaternion.identity);
                Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z), Quaternion.identity);
                Instantiate(projectile, new Vector3(transform.position.x, transform.position.y - .3f, transform.position.z), Quaternion.identity);
                break;
            default:
                Instantiate(projectile, transform.position, Quaternion.identity);
                break;
        }




    }
    void Update()
    {
        
        timer += Time.deltaTime;
        if(timer>= attackspeed)
        {
            dropped = GetComponent<drag>().dropped;
            if(dropped)
            {
                if (detectionsquare.GetComponent<detect>().triggered == true)
                {
                    anim.SetTrigger("ToAttack");
                    fire();
                    timer = 0;
                }
            }
            else
            {
                anim.ResetTrigger("ToAttack");
            }


        }
    }


}
