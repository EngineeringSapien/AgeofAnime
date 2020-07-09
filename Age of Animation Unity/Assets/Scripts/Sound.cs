using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    private AudioSource bgMusic;
    private List<AudioClip> allMusic = new List<AudioClip>();

    public AudioClip narutoMusic;
    public AudioClip narutoShippuddenMusic;
    public AudioClip DBZMusic;
    public AudioClip BleachMusic;
    public AudioClip FullMetalMusic;

    public Age age;


    private void Awake()
    {
        allMusic.AddRange(new AudioClip[] { narutoMusic, narutoShippuddenMusic, DBZMusic, BleachMusic, FullMetalMusic });
    }


    private void Start()
    {
        bgMusic = gameObject.GetComponent<AudioSource>();
        bgMusic.Play();
    }


    public void ChangeMusic(int _age)
    {
        if (_age > age.globalAge)
        {
            bgMusic.Stop();
            bgMusic.clip = allMusic[_age];
            bgMusic.Play();
        }
    }

}
