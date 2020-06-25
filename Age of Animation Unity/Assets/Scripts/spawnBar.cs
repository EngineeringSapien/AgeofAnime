using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBar : MonoBehaviour {

    public float spawnTime;
    private float startingTime;
    private float remainingTime;

    private Transform Bar;



    void Start ()
    {
        startingTime = Time.time;           //0 seconds

        Bar = transform.Find("Bar");
    }

    void Update ()
    {
        remainingTime = Time.time - startingTime;    // time since startingTime (e.g. 1s ; 2s; 3s; 4s;)

        //Debug.Log("Starting Time " + startingTime);
        //Debug.Log("Remaining Time " + remainingTime);

        if (remainingTime <= spawnTime)
        {
            Bar.localScale = new Vector3(remainingTime / spawnTime, 1f);        // (1/5 ; 2/5 ; 3/5 ; etc)
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
