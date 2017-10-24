using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainer : MonoBehaviour {

    float leftlimit;
    float rightlimit;

    bool orientation; //izquierda (falso), derecha (verdadero)

	
    // Use this for initialization
	void Start ()
    {
        leftlimit = -1.5f;
        rightlimit = 1.5f;
        orientation = false;
    }
	
	// Update is called once per frame
	void Update ()
    {	
        if(orientation)//derecha
        {
            if(gameObject.transform.position.x < rightlimit)
                gameObject.transform.Translate(Vector3.right* Time.deltaTime);
            else
                orientation = false;
        }
        else//izquierda
        {
            if (gameObject.transform.position.x > leftlimit)
                gameObject.transform.Translate(Vector3.left * Time.deltaTime);
            else
                orientation = true;
        }


        if(transform.childCount==0)
        {
            GameManager.instance.ChangeLvl();
            
        }
	}
}
