using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class spawnBar : MonoBehaviour {

    public float unitsSpawnTime;
    private float startingSpawnTime;
    private float remainingSpawnTime;

    private Transform Bar;


    void Start ()
    {
        startingSpawnTime = Time.time;

        Bar = transform.Find("Bar");
    }


    void Update ()
    {
        remainingSpawnTime = Time.time - startingSpawnTime;

        if (remainingSpawnTime <= unitsSpawnTime) { Bar.localScale = new Vector3(remainingSpawnTime / unitsSpawnTime, 1f); }

        else { Destroy(gameObject); }
    }

}
