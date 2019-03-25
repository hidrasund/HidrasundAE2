using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthAndSanity : MonoBehaviour {

    private Text MyTXT;
    public int maxHP = 10;
    public int CurrentHP = 10;
    // Start is called before the first frame update
    void Start()
    {
        MyTXT = GameObject.Find("Text1").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MyTXT.text = CurrentHP.ToString();
    }
}
