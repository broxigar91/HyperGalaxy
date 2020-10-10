using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public List<GameObject> enemies;
    public float leftlimit = -1.5f;
    public float rightlimit = 1.5f;
    public float spawnRate;
    bool orientation; //izquierda (falso), derecha (verdadero)

    // Use this for initialization
    void Start () {
        orientation = false;

        InvokeRepeating("SpawnEnemy", 5, spawnRate);
    }
	

	// Update is called once per frame
	void Update () {

        if (orientation)//derecha
        {
            if (gameObject.transform.position.x < rightlimit)
                gameObject.transform.Translate(Vector3.right * Time.deltaTime);
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
    }

    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemies.Count - 1);

        Instantiate(enemies[enemyIndex], this.transform);
    }
}
