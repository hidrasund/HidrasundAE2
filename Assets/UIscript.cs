using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour
{
    //Text
    public Text Health;
    public Text Sanity;
    //Booleans
    public bool Dynamite;
    
    public bool Ouija;
    //GameObjects
    public GameObject Dyna;
    public GameObject Crystal;
    public GameObject OuiOui;
    //Numbers
    public float HealthAmount;
    public float SanityAmount;

    // Start is called before the first frame update
    void Start()
    {
        Dynamite = false;
        
        Ouija = false;


    }

    // Update is called once per frame
    void Update()
    {
        //Checks the booleans from the GameManger to check if they are true or not.
        Dynamite = GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().Dynamite;
       
        Ouija = GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().ouiouiBoard;
        //Checks the amount of Sanity and heal the player has
        HealthAmount = GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().PlayerHealth;
        SanityAmount = GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().PlayerSanity;
        //Converts the Health amount into a displayable String.
        Health.text = (HealthAmount.ToString("00"));
        Sanity.text = (SanityAmount.ToString("00"));

        //Displays the items.
        if (Dynamite == true) 
        {
            Dyna.SetActive(true);
        }

        if(Crystal == true)
        {
            Crystal.SetActive(true);
        }

        if (Ouija == true)
        {
            OuiOui.SetActive(true);
        }



    }
}
