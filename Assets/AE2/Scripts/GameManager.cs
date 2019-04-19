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

    //basement variables
    public bool BasementLoaded;

    public int BasementDoors;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = 10;
        PlayerSanity = 10;
        ouiouiBoard = false;
        CrystalBall = false;

        Dynamite = false;
        Scenario = false;
        ScenarioTimer = 400;

        NPC1 = false;
        NPC2 = false;
        NPC3 = false;
        BasementLoaded = false;
        BasementDoors = 0;

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

        if(Scenario == true)
        {
            ScenarioTimer -= Time.deltaTime;
        }

        if ((BasementDoors == 6) && (Scenario = false))
        {
            ScenarioStart();
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

    //scenario start function
    public void ScenarioStart()
    {
        Scenario = true;
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

    //Basement Functions
    public void DoorCount()
    {
        BasementDoors = (BasementDoors + 1);
    }
    
    //Scenario Activated

    public void ScenarioActive()
    {
        //Teleport Player to a room
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-1, 1, 2);

        //Teleport NPC's to a room
        GameObject.FindGameObjectWithTag("Morty").transform.position = new Vector3(-5, 1, 12);
        GameObject.FindGameObjectWithTag("Tux").transform.position = new Vector3(0, 0, 0);
        //Activate Bombs
        GameObject.FindGameObjectWithTag("Bomb").SetActive(true); //sets all the bombs to be active
        //Display Timer
        //Set game over if timer runs out
        //Set win if player interacts with dynamite on the door


    }

}
