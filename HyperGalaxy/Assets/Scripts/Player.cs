using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    public float speed; //velociad con la que se mueve el sprite
    float direccionX;
    Rigidbody2D rb;
    public GameObject projectile;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        direccionX = CrossPlatformInputManager.GetAxis("Horizontal");

        if(CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direccionX * speed, 0);
    }

    private void Shoot()
    {
        Transform bulletPos= GameObject.Find("BulletStart").transform;
        Instantiate(projectile,bulletPos.position ,Quaternion.identity);
    }
}
