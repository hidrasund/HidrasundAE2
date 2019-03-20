using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public GameObject Player;
    private Vector3 Coordinates;

    // Use this for initialization
    void Start()
    {
        Coordinates = Player.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Player.transform.position = Coordinates;
        }
    }
}

//Written and commented by Alex Betson