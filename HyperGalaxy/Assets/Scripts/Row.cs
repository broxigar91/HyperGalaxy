using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{

    public GameObject go;

    EnemyContainer ec;



    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
            Destroy(gameObject);
    }    
}
