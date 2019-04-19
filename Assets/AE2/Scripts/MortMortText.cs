using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MortMortText : MonoBehaviour
{
    public int Dialogue;
    public Text Stage; //Assign the text on the cavas to this in the editor


    // Start is called before the first frame update
    void Start()
    {

        Dialogue = 0; //Public INT to check what stage of the dialogue is on


    }

    // Update is called once per frame
    void Update()
    {

        if ((Dialogue == 0)) // This will make the text invisible
        {
            Stage.text = ("Press E to Talk");
        }

        if ((Dialogue == 1)) //Stage 2
        {
            Stage.text = ("My name is Mortimer, I'm a Scientist, Can't you tell?");
        }

        if ((Dialogue == 2)) //Stage 3
        {
            Stage.text = ("I was hired to investigate explosions and how to make them bigger! I'm not meant to be telling strangers this!");
        }

        if ((Dialogue == 3)) //Stage 3
        {
            Stage.text = ("Goodbye M'lady, Have a blast exploring the house!");
        }
    }

    public void StageUp() //function to up the stage when interacted with
    {
        if (Dialogue != 4)
        {
            Dialogue = (Dialogue + 1);
        }

        if (Dialogue == 4)
        {

            Dialogue = 0;

            GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().NPC2true();
        }


    }
}
