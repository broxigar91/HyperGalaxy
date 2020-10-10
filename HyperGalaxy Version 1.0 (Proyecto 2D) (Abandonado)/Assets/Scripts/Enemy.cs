using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


    public int points;
    public float limit;
    private GameObject player;
    Rigidbody2D eBody;
    bool orientation;
    
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
        eBody = GetComponent<Rigidbody2D>();
        orientation = false;
	}
	
	// Update is called once per frame
	void Update () {
    }


}
