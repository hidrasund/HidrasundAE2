using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MortyText : MonoBehaviour
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
            Stage.text = ("My name is Jeremy Tux! Would you like to star in my upcoming award winning film? Fame and Stardom awaits you!");
        }

        if ((Dialogue == 2)) //Stage 3
        {
            Stage.text = ("I hear the special effects quality here are AMAZING! Thank you for being a part of my film! You're going to be on the cover of so many magazines!");
        }

        if ((Dialogue == 3)) //Stage 3
        {
            Stage.text = ("Farewell! Remember to keep up the good work! You're an amazing Actress!");
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
