using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSoundFX : MonoBehaviour {

    private AudioSource unitSounds;

    public AudioClip walkSound;
    public AudioClip meleeSound;
    public AudioClip rangeSound;


    private void Start()
    {
        unitSounds = gameObject.GetComponent<AudioSource>();
    }


    public void PlayMeleeSound()
    {
        unitSounds.Stop();
        unitSounds.clip = meleeSound;
        unitSounds.Play();
    }


    public void PlayRangeSound()
    {
        unitSounds.Stop();
        unitSounds.clip = rangeSound;
        unitSounds.Play();
    }


    public void PlayWalkSound()
    {
        unitSounds.Stop();
        unitSounds.clip = walkSound;
        unitSounds.Play();
    }


    public void StopSounds()
    {
        unitSounds.Stop();
    }

}
