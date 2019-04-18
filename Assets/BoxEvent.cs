using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxEvent : MonoBehaviour
{
    public bool interacted;
    public float timer;
    public Text boxtext;

    // Start is called before the first frame update
    void Start()
    {
        
        interacted = false;
        timer = 5;


    }

    // Update is called once per frame
    void Update()
    {

        if (timer >= 4)
        {
            boxtext.text = ("Press E to Select a Box.");
        }

        if (timer <= 0)
        {
            boxtext.text = ("The Box is locked.");
        }

        if (interacted == true && timer >= 0) 
        {
            boxtext.text = ("You obtain Dynamite. You hear the other box lock itself.");
            timer -= Time.deltaTime;
        }


    }

    public void boxopen()
    {
        if (timer >= 5)
        {
            interacted = true;
            GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().DynamiteGET();
        }
    }
}
