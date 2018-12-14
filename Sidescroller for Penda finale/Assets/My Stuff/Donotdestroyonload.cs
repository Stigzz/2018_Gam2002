using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donotdestroyonload : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        DontDestroyOnLoad(player);
		
	}
}
