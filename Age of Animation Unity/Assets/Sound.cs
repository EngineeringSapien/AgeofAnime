using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    private List<AudioClip> Music = new List<AudioClip>();

    public AudioSource BMG;

    public AudioClip narutoMusic;
    public AudioClip narutoShippuddenMusic;
    public AudioClip DBZMusic;
    public AudioClip BleachMusic;
    public AudioClip FullMetalMusic;

    public Age age;

    private AudioSource[] allAudioSources;

    private void Awake()
    {
        Music.AddRange(new AudioClip[] { narutoMusic, narutoShippuddenMusic, DBZMusic, BleachMusic, FullMetalMusic });
    }

    private void Start()
    {
        BMG.Play();
    }


    public void ChangeMusic(int _age)
    {
        

            if (_age <= age.globalAge)
        {
            Debug.Log("Do Nothing");
        }
        else if (_age > age.globalAge)
        {
            BMG.Stop();
            Debug.Log("P1 Age right before music is to play" + _age + Music[_age]);
            BMG.clip = Music[_age];
            BMG.Play();
        }
    }


}
