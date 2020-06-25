using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonClick : MonoBehaviour {

    public KeyCode button_key;

    public bool key_pressed = false;
    public bool click;

    public Button _button;

    void Awake()
    {
        _button = GetComponent<Button>();
    }

	
	// Update is called once per frame
	void Update ()
    {
        /*if (Input.GetKeyDown(button_key))                   //remember to delete this after testing parameters
        {
            Click();
        }*/


        key_pressed = false;
        click = false;

	}

    public void PlayerClick()
    {
        key_pressed = true;
    }


    public void Click()
    {
        key_pressed = true;
        _button.onClick.Invoke();
    }
}
