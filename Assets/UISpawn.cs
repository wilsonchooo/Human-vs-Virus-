using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tower;
    public GameObject spawnpoint;
    GameObject currencyUI;
    float currency;
    int price;
    UI GM;
    void Start()
    {
        currencyUI = GameObject.FindGameObjectWithTag("CurrencyUI");
        GM = currencyUI.GetComponent<UI>();
        price = tower.GetComponent<Towers>().price;
    }

    public void spawn()
    {
        //Debug.Log(GM.returncurrency());
        //Debug.Log(price);
        
        if (GM.returncurrency() - price >=0)
        {
            GM.changecurrency(-price);
            Instantiate(tower, spawnpoint.transform.position, Quaternion.identity);
        }

        else Debug.Log("No money");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
