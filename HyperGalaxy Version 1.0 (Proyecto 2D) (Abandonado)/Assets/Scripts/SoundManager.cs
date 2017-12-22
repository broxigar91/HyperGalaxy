using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioSource efx; //efectos de audio
    public AudioSource music; //musica de fondo


    public List<AudioClip> efxClips;
    public List<AudioClip> musicClips;

    public static SoundManager instance;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else if (instance!=this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        PlayMusic(0);
    }

    //metodo que reproduce un solo clip de audio, en concreto efectos de audio como explosiones, lasers, etc
    public void PlayEfx(int index)
    {
        efx.PlayOneShot(efxClips[index],0.7f);
    }

    public void PlayMusic(int index)
    {
        music.clip = musicClips[index];
        music.loop = true;
        music.Play();
    }
}
