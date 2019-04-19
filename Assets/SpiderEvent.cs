using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiderEvent : MonoBehaviour
{
    public bool Event;
    public Text Interact;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {

        Event = false;
        timer = 5;

    }

    // Update is called once per frame
    void Update()
    {

        if (Event == false)
        {
            Interact.text = ("Press E to Interact!");
        }
        
        if (Event == true)
        {
            Interact.text = ("The Spider attacks you, You realise whatever is in the box is not worth risking your life for." +
                "-1 Health");
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            Event = false;
            timer = 5;
        }


    }

    public void EventStart()
    {
        Event = true;
        GameObject.FindGameObjectWithTag("GameMAN").GetComponent<GameManager>().Damage();
    }



}
