using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealTowerAttack : MonoBehaviour
{

    public GameObject attack;
    float timer;
    bool dropped;
    public GameObject detectionsquare;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

            dropped = GetComponent<drag>().dropped;
            if (dropped)
            {
                if (detectionsquare.GetComponent<detect>().triggered == true)
                {
                    //anim.SetTrigger("ToAttack");
                    attack.SetActive(true);
                    timer = 0;
                }
                else attack.SetActive(false);
            }
            else
            {
                //anim.ResetTrigger("ToAttack");

            }


        
    }

}
