using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sanityBar : MonoBehaviour
{
    private Text MyTXT;
    public int maxSP = 10;
    public int CurrentSP = 10;
    // Start is called before the first frame update
    void Start()
    {
        MyTXT = GameObject.Find("Text2").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MyTXT.text = CurrentSP.ToString();
    }
}
