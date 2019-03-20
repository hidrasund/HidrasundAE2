using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindInteractableObjects : MonoBehaviour
{
    private GameObject[] Interactables; //Will provide a list of interact-able objects
    private Renderer[] Renderers; //Provides a list of renderers on those interact-able objects

    private void Start()
    {
        Interactables = GameObject.FindGameObjectsWithTag("Interactable"); //Immediately fills out the 'Interactables' list
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl)) //While you hold Left Control...
        {
            foreach (GameObject Interactable in Interactables) //Goes through each interact-able object in the 'Interactables' list
            {
                Renderers = Interactable.GetComponentsInChildren<Renderer>(); //Finds all the renderer components in the 'Interactables' list
                foreach (Renderer renderer in Renderers)
                {
                    renderer.material.color = Color.green; //Sets the interact-able objects to green
                }
            }
        }
        else //When you let go of Left Control...
        {
            foreach (GameObject Interactable in Interactables) //Goes through each interact-able object in the 'Interactables' list
            {
                Renderers = Interactable.GetComponentsInChildren<Renderer>(); //Finds all the renderer components in the 'Interactables' list
                foreach (Renderer renderer in Renderers)
                {
                    renderer.material.color = Color.white; //Sets the interact-able objects back to the original colour
                }
            }
        }
    }
}

//Written and commented by Alex Betson