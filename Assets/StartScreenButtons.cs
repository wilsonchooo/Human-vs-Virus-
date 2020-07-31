using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScreenButtons : MonoBehaviour
{
    public GameObject startbutton;
    public GameObject instructionsbutton;
    public GameObject title;
    public GameObject instructions;
    public GameObject back;

    public GameObject sansexplanation;
    public GameObject fireexplanation;
    public GameObject iceexplanation;
    public GameObject meleeexplanation;

    public GameObject sans;
    public GameObject fire;
    public GameObject ice;
    public GameObject melee;
    // Start is called before the first frame update
    void Start()
    {
        startbutton.SetActive(true);
        instructionsbutton.SetActive(true);
        title.SetActive(true);
        instructions.SetActive(false);
        back.SetActive(false);

        sansexplanation.SetActive(false);
        fireexplanation.SetActive(false);
        iceexplanation.SetActive(false);
        meleeexplanation.SetActive(false);

        sans.SetActive(false);
        fire.SetActive(false);
        ice.SetActive(false);
        melee.SetActive(false);
    }

    public void startgame()
    {
        SceneManager.LoadScene(1);
    }

    public void instructionsshow()
    {
        startbutton.SetActive(false);
        instructionsbutton.SetActive(false);
        title.SetActive(false);
        instructions.SetActive(true);
        back.SetActive(true);

        sansexplanation.SetActive(true);
        fireexplanation.SetActive(true);
        iceexplanation.SetActive(true);
        meleeexplanation.SetActive(true);

        sans.SetActive(true);
        fire.SetActive(true);
        ice.SetActive(true);
        melee.SetActive(true);
    }

    public void backbutton()
    {
        startbutton.SetActive(true);
        instructionsbutton.SetActive(true);
        title.SetActive(true);
        instructions.SetActive(false);
        back.SetActive(false);

        sansexplanation.SetActive(false);
        fireexplanation.SetActive(false);
        iceexplanation.SetActive(false);
        meleeexplanation.SetActive(false);

        sans.SetActive(false);
        fire.SetActive(false);
        ice.SetActive(false);
        melee.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
