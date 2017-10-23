using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Rigidbody2D rb;
    public float velY;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(gameObject!=null)
        {
            Destroy(gameObject, 3.0f);
        }

        rb.velocity = Vector2.up * velY;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag!="Player")
        {
            //GameManager.instance.Score += collision.gameObject.GetComponent<Enemy>().points;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
             
    }
}
