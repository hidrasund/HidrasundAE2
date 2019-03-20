using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterXSeconds : MonoBehaviour
{
    public float Timer; //A public timer that can be changed in the editor
    public enum DeleteOrDisable { Delete = 0, Disable = 1} //Gives a choice in the editor to either delete or disable
    public DeleteOrDisable Choice = DeleteOrDisable.Delete; //Sets default choice to delete

    // Update is called once per frame
    void Update()
    {
        if (Choice == DeleteOrDisable.Delete)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                Destroy(gameObject); //Deletes the gameobject
            }
        }
        else
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                gameObject.SetActive(false); //Disables the gameobject
            }
        }

    }
}

//Written and commented by Alex Betson