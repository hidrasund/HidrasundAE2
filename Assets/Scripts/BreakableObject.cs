using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    public GameObject Particles, Item;
    public enum SpawnItemInside { No = 0, Yes = 1 } //Gives a choice in the editor to either spawn an item, or not spawn anything
    public SpawnItemInside SpawnItem = SpawnItemInside.No; //Sets default choice to not spawn an item

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Interactable") //Checks if an interactable object collides with the breakable object
        {
            gameObject.SetActive(false); //Disables the gameobject
            Instantiate(Particles, transform.position, Quaternion.Euler(0, 0, 0)); //Spawns the pre-made particles
            if (SpawnItem == SpawnItemInside.Yes) 
            {
                Instantiate(Item, new Vector3(transform.position.x, transform.position.y + 1.2f, transform.position.z), transform.rotation); //Spawn an item slightly above the particles
            }

        }
    }

}

//Written and commented by Alex Betson