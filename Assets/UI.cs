using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public Text UIcurrency;

    [SerializeField] private int currency;
    void Start()
    {
        currency = 10;
        UIcurrency.text = currency.ToString();
    }

    private void Awake()
    {
        currency = 10;
    }

    public int returncurrency()
    {
        return currency;
    }
    public void changecurrency(int amount)
    {

        currency += amount;
        //Debug.Log(currency);
        UIcurrency.text = currency.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        UIcurrency.text = currency.ToString();
    }
}
