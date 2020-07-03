using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;

    public bool Horizontal = false;


    void Update()
    {
        if (Input.GetKeyDown("space")) { ChangeSplitScreen(); }
    }


    public void ChangeSplitScreen()
    {
        Horizontal = !Horizontal;

        if (Horizontal)
        {
            cam1.rect = new Rect(0, .5f, 1, .5f);
            cam2.rect = new Rect(0, 0, 1, .5f);
        }
        else
        {
            cam1.rect = new Rect(0, 0, 1f, 1f);
            cam2.enabled = false;
        }
    }

}
