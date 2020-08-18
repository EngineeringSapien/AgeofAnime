using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class CameraMove : MonoBehaviour {

    public KeyCode left_key;
    public KeyCode right_key;

    public float speed = 5f;
    private float screenEdgeOffset = 30f;
    public int boundOffset;

    public GameObject LeftBound;
    public GameObject RightBound;


    void Awake ()
    {
        transform.position = new Vector3(0, -.58f, -5);
		
	}

    void Update()
    {

        //Right bound
        if (gameObject.transform.position.x < RightBound.transform.position.x + boundOffset) 
        {
            if (Input.GetKey(right_key))
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }


            if (Input.mousePosition.x > Screen.width - screenEdgeOffset)
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }

        //Left bound
        if (gameObject.transform.position.x > LeftBound.transform.position.x - boundOffset)
        {
            if (Input.GetKey(left_key))
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
            
            if (Input.mousePosition.x < screenEdgeOffset)
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
        }  
    }
}
