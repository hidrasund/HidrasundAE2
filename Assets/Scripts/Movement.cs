using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float WalkSpeed = 0.1f, RunSpeed = 0.2f; //Variables that can be set in the editor
    private float Speed; 

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = RunSpeed; //If you hold left shift, the player moves at 1 speed
        }
        else
        {
            Speed = WalkSpeed; //If you let go of left shift, the player moves at 0.5 speed
        }

        float ForwardBackwardTranslation = Input.GetAxis("Vertical") * Speed; //Sets forward and backward movements
        float LeftRightTranslation = Input.GetAxis("Horizontal") * Speed; //Sets left and right movements

        transform.Translate(new Vector3(LeftRightTranslation, 0, ForwardBackwardTranslation)); //Applies the above movements to the player
    }
}

//Written and commented by Alex Betson