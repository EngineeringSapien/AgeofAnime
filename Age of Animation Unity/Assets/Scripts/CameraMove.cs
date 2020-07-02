using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class CameraMove : MonoBehaviour {

    public KeyCode left_key;
    public KeyCode right_key;

    public float speed = 5f;

    public int bound;

    public GameObject LeftBound;
    public GameObject RightBound;


    void Awake ()
    {
        transform.position = new Vector3(0, -2.4f, -5);
		
	}

    void Update()
    {
        float edgeSize = 30f;

        //Right bound
        if (gameObject.transform.position.x < RightBound.transform.position.x + bound) 
        {
            if (Input.GetKey(right_key))
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }


            if (Input.mousePosition.x > Screen.width - edgeSize)
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }

        //Left bound
        if (gameObject.transform.position.x > LeftBound.transform.position.x - bound)
        {
            if (Input.GetKey(left_key))
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
            
            if (Input.mousePosition.x < edgeSize)
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
        }  
    }
}
