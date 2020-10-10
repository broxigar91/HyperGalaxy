using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public Text scoreText, lvlText;


    private int score,lvl,lifes;
    


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
        lvl = 1;
        lifes = 3;
	}


    public void StartGame()
    {
        scoreText.gameObject.SetActive(true);
        lvlText.gameObject.SetActive(true);
        LevelManager.instance.ResetGame();
    }

    // Update is called once per frame
    void Update () {
        //scoreText.text = "Score\n"+score;
        //lvlText.text = "Nivel\n" + lvl;
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

    public int Lvl
    {
        get
        {
            return lvl;
        }

        set
        {
            lvl = value;
        }
    }

    public int Lifes
    {
        get
        {
            return lifes;
        }

        set
        {
            lifes = value;
        }
    }

    public void Save()
    {
        JsonUtility.ToJson(score);
    }

    public void ChangeLvl()
    {
        if(Lvl <= 4)
        {
            LevelManager.instance.LoadLevel(1);
        }
        else if(Lvl <=8)
        {
            LevelManager.instance.LoadLevel(2);
        }
        else
        {
            LevelManager.instance.LoadLevel(3);
        }
    }

}
