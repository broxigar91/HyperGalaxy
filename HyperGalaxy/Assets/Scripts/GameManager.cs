using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private int score;

    public static GameManager instance;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else if(instance!=this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
        score = 0;
	}
	

	// Update is called once per frame
	void Update () {
		
	}

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

}
