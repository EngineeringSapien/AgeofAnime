using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class spawnBar : MonoBehaviour {

    private float unitsSpawnTime;
    private float startingSpawnTime;
    private float timeSinceStart;

    private Slider slider;

    private bool spawning;


    void Start ()
    {
        slider = gameObject.GetComponent<Slider>();
    }


    void Update ()
    {
        if (spawning)
        {
            timeSinceStart = Time.time - startingSpawnTime;
            slider.value = timeSinceStart / unitsSpawnTime;

            if (timeSinceStart >= unitsSpawnTime) { spawning = false; }
        }

        else { slider.value = 0; }

    }


    public void StartSpawnBar(float spawnTime)
    {
        unitsSpawnTime = spawnTime;
        startingSpawnTime = Time.time;
        spawning = true;
    } 

}
