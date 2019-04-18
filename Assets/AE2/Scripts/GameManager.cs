using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    //General gameplay variables
    public float PlayerHealth;
    public float PlayerSanity;
    //Inventory Booleans
    public bool ouiouiBoard;
    public bool CrystalBall;

    //Scenario related
    public bool Dynamite;
    public bool Scenario;
    public float ScenarioTimer;

    //Bools to check if the player has spoken to a character for the first time.
    public bool NPC1;
    public bool NPC2;
    public bool NPC3;

    public bool BasementLoaded;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = 10;
        PlayerSanity = 10;
        ouiouiBoard = false;
        CrystalBall = false;

        Dynamite = false;
        Scenario = false;
        ScenarioTimer = 360;

        NPC1 = false;
        NPC2 = false;
        NPC3 = false;
        BasementLoaded = false;

        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
        if(PlayerHealth <= 0) //Checks if the players health if above 0. If it isnt, then the player dies. Because people die when they are killed.
        {
            Death();
        }


        if((NPC1 == true) && (NPC2 == true) && (BasementLoaded == false))
        {
            LoadBasement();
        }

    }

    public void Death() //Destroys the current GameManager so it does not create 2 when the game is started again and sends the players to the main menu.
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("Main menu");
        
    }

    public void LoadBasement()
    {
        BasementLoaded = true;
        SceneManager.LoadScene("Basement", LoadSceneMode.Additive);
    }

    //Health and Sanity Functions.
    public void Damage()
    {
        PlayerHealth = (PlayerHealth - 1);
    }

    public void SanityDown()
    {
        PlayerSanity = (PlayerSanity - 1);
    }


    //Item Functions
    public void DynamiteGET()
    {
        Dynamite = true;
    }

    public void OuijaBoardGET()
    {
        ouiouiBoard = true;
    }

    public void BallGET()
    {
        CrystalBall = true;
    }

    //NPC Functions
    public void NPC1true()
    {
        NPC1 = true;
    }

    public void NPC2true()
    {
        NPC2 = true;
    }

    public void NPC3true()
    {
        NPC3 = true;
    }

    

}
