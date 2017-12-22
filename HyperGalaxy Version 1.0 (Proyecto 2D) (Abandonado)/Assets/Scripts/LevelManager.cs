using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void LoadLevel(int scene)
    {
        SceneManager.LoadScene(scene);
        GameManager.instance.Lvl++;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(1);
        GameManager.instance.Lvl = 1;
        GameManager.instance.Score = 0;
    }
}
