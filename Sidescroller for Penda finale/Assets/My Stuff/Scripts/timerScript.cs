using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timerScript : MonoBehaviour
{

    public Text thisTimer;
    private float timerStart;
    public float timerPlay;

    // Use this for initialization
    void Start()
    {
        timerStart = Time.time;

    }

    // Update is called once per frame
    void Update()
    {

        timerPlay = Time.time - timerStart;

        string minutes = ((int)timerPlay / 60).ToString("00");
        string seconds = (timerPlay % 60).ToString("00");
        string miliseconds = ((int)(timerPlay * 100f) % 100).ToString("00");
        thisTimer.text = minutes + ":" + seconds + ":" + miliseconds;

    }
}