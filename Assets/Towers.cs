using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    // Start is called before the first frame update
    public float health;
    public int price;

    public int form;

    public GameObject tileplacedon;
    float dietimer;
    Animator anim;

    float initialhealth;

    Vector3 og;
    void Start()
    {
        anim = GetComponent<Animator>();
        form = 0;
        og = transform.localScale;
        initialhealth = health;
        
    }

    public int returnform()
    {
        return form;
    }

    public void changeform(int change)
    {

        if(form + change >=3 )
        {
            form = 2;
        }

        else 
        form += change;

        Debug.Log(form);

    }
    void changeappearance()
    {
        if(form ==1)
        {
            if(gameObject.name == "Fire Totem(Clone)" || gameObject.name == "ice totem(Clone)")
            {
                GetComponent<towerattack>().attackspeed = 2.2f;
                health = initialhealth * 1.5f;

            }


            if (gameObject.name == "Tank Totem(Clone)")
            {
                health = initialhealth * 2;

            }


            transform.localScale = new Vector3(og.x + .2f, og.y + .2f, transform.localScale.z);
            //GetComponent<SpriteRenderer>().color = new Color(255f/255f, 136f/255f, 136f/255f,1f);
            //GetComponent<SpriteRenderer>().color = Color.red;

        }

        if (form == 2)
        {
            if (gameObject.name == "Fire Totem(Clone)" || gameObject.name == "ice totem(Clone)")
            {
                health = initialhealth * 2f;
                GetComponent<towerattack>().attackspeed = 2;
            }

            if (gameObject.name == "Tank Totem(Clone)")
            {
                health = initialhealth * 3;

            }
            transform.localScale = new Vector3(og.x + .3f, og.y + .3f, transform.localScale.z);
            //GetComponent<SpriteRenderer>().color = new Color(239f/255f, 56f/255f, 56f/255f,1f);

        }
    }

    public void setTile(GameObject Tile)
    {
        tileplacedon = Tile;
    }

    void resetTile()
    {
        tileplacedon.GetComponent<PlaceTile>().Reset();
    }
    
    // Update is called once per frame
    void Update()
    {
        changeappearance();
        
        if(health <=0)
        {
            //anim.SetTrigger("ToDie");
            resetTile();
            Destroy(this.gameObject);
        }
        
    }
}
