﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairRaycastScript : MonoBehaviour
{
    public float Range, ThrowSpeed; //Variables that are changeable in the editor
    private bool HoldingItem = false; //Bool that changes when the player picks up, or drops/throws, an object
    private GameObject HeldItem; //Temporarily holds information on an item when picked up
    private GameObject Character; //Temporarily holds information on character that is interacted with

    //MAKE SURE THAT ANY INTERACT-ABLE OBJECTS HAVE THE CORRECT TAG -----> "Interactable"

    void Update()
    {
        RaycastHit Hit;
        if (Input.GetKeyDown(KeyCode.E) && HoldingItem == false) //Pick up item in range
        {
            if (Physics.Raycast(transform.position, transform.forward, out Hit, Range)) //Raycasting from center of player's head
            {
                if (Hit.transform.tag == "Interactable") //Only works on objects tagged as "Interactable"
                {
                    HeldItem = Hit.transform.gameObject; //Sets HeldItem to the current held item
                    ObjectPickUp();
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) && HoldingItem == true) //Drop held item
        {
            ObjectDrop();
        }
        else if (Input.GetMouseButtonDown(0) && HoldingItem == true) //Throw held item
        {
            ObjectThrow();
        }

        /*---------Debug---------
        Debug.Log(HoldingItem); 
        Debug.Log(HeldItem); 
        -----------Debug-------*/

        //Jordon Comments from Here
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out Hit, Range))
            {
                if (Hit.transform.tag == "Tux")
                {
                    Character = Hit.transform.gameObject; //Checks to see what character was interacted with (Could make this an if statement for characters?)
                    Tuxdialogue();//If Tux is interacted with
                }
                if (Hit.transform.tag == "Morty")
                {
                    Character = Hit.transform.gameObject; //Checks to see what character was interacted with (Could make this an if statement for characters?)
                    Mortydialogue();//If Morty is interacted with
                }
                if (Hit.transform.tag == "Kitty")
                {
                    Character = Hit.transform.gameObject;
                    Kitty(); // If Sphinx is interacted with
                }
                if (Hit.transform.tag == "Spider")
                {
                    Character = Hit.transform.gameObject; //Spider event
                    GameObject.FindGameObjectWithTag("Spider").GetComponent<SpiderEvent>().EventStart();
                }
                if (Hit.transform.tag == "Box")
                {
                    Character = Hit.transform.gameObject; //Box Event
                    GameObject.FindGameObjectWithTag("Box").GetComponent<BoxEvent>().boxopen();
                }
                if (Hit.transform.tag == "Door") //Interacted with door
                {
                    Hit.transform.gameObject.SetActive(false); //Sets door to dissapear
                    if(GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().BasementLoaded == true)
                    {
                        //if the basement is loaded then the count of doors opened in basement goes up, this will be used to trigger the end scenario after all the doors are open
                        GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().DoorCount();
                    }
                }

            }
        }



    }

    void ObjectPickUp()
    {
        HoldingItem = true;
        HeldItem.GetComponent<Rigidbody>().useGravity = false; //Turns gravity off on the item so it doesn't drop when you're holding it
        HeldItem.GetComponent<Rigidbody>().isKinematic = true; //Sets the item to be kinematic
        HeldItem.transform.parent = gameObject.transform; //Makes the player's head the parent of the item so that it moves and rotates in sync with the player
    }
    void ObjectDrop()
    {
        HoldingItem = false;
        HeldItem.GetComponent<Rigidbody>().useGravity = true; //Turns gravity on
        HeldItem.GetComponent<Rigidbody>().isKinematic = false; //Sets the item to NOT be kinematic
        HeldItem.transform.parent = null; //Resets the item's parental hierarchy
        HeldItem = null; //Clears the variable of the item's information
    }
    void ObjectThrow()
    {
        HoldingItem = false;
        HeldItem.GetComponent<Rigidbody>().velocity = transform.forward * ThrowSpeed; //Adds an initial speed to the object to simulate it being thrown
        HeldItem.GetComponent<Rigidbody>().useGravity = true; //Turns gravity on
        HeldItem.GetComponent<Rigidbody>().isKinematic = false; //Sets the item to NOT be kinematic
        HeldItem.transform.parent = null; //Resets the item's parental hierarchy
        HeldItem = null; //Clears the variable of the item's information
    }

    void Tuxdialogue()
    {
        GameObject.FindGameObjectWithTag("Tux").GetComponent<TuxDialogue>().StageUp();
        //This will advance the dialogue Re use this code and change the tag depending on character
    }


    void Mortydialogue()
    {
        GameObject.FindGameObjectWithTag("Morty").GetComponent<MortMortText>().StageUp();
        //This will advance the dialogue Re use this code and change the tag depending on character
    }

    void Kitty()
    {
        GameObject.FindGameObjectWithTag("Kitty").GetComponent<KittyChallenge>().KittyUp();
        //Interacts with the Sphinx.
    }


}

//Written and commented by Alex Betson