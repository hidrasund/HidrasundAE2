using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KittyChallenge : MonoBehaviour
{
    bool Interacted; //Interacted state
    int KittyState;
    public Text KittySpeak; //Text that is displayed
    public Text Answers;
    public bool Correct;
    public Text hint;

    float timer; //timer until sphinx dissapears

    // Start is called before the first frame update
    void Start()
    {
        KittyState = 0;
        Interacted = false;
        Correct = false;

        timer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //General talking
        if(KittyState == 0)
        {
            KittySpeak.text = ("Press E to Interact");
        }

        if (KittyState == 1)
        {
            KittySpeak.text = ("Answer my question foolish mortal. Or you shall not be granted passage.");
        }



        //The Challenge
        if (KittyState == 2)
        {
            KittySpeak.text = ("What comes once in a minute, Twice in a Moment, But never in A Thousand Years?");
            Answers.text = ("1. The Letter M.  2. My Ex Boyfriend...   3. A Jaguar");
            hint.text = ("Press the Correspond Number on your Keyboard");
        }

        if (KittyState == 2 && Input.GetKeyDown(KeyCode.Alpha1))
        {
            KittyState = 3;
            Correct = true;
        }

        if (KittyState == 2 && Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3)) 
        {
            KittyState = 4;
        }


        if (KittyState == 3)
        {
            KittySpeak.text = ("That is Correct! Perhaps you're not as stupid as you look. Continue exploring at your own risk, It's getting dangerous around here...");
            timer -= Time.deltaTime;
            Answers.text = (" ");
            hint.text = (" "); //make Answers and Hint dissapear.
        }

        if (KittyState == 4)
        {
            KittySpeak.text = ("You Fool! It's the letter M you dunce. Face the punishment of your ignorance!");
            timer -= Time.deltaTime;
            //Sanity - 1;
            Answers.text = (" ");
            hint.text = ("You Lose -1 Sanity"); //make Answers and Hint dissapear.
        }

        if (timer <= 0)
        {
            Destroy(gameObject); //Destroys the sphinx, allowing the player to pass
        }

    }

    public void StateChange()
    {
        Interacted = true;
    }

    public void KittyUp()
    {
        if (KittyState <= 1)
        {
            KittyState++;
        }


    }
}
