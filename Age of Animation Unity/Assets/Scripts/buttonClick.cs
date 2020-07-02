using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonClick : MonoBehaviour {

    public bool key_pressed = false;
    public Button _button;



    void Awake()
    {
        _button = GetComponent<Button>();
    }

	
	void Update ()
    {

        key_pressed = false;

	}

    public void PlayerClick()
    {
        key_pressed = true;
    }


    public void BotClick()
    {
        key_pressed = true;
        _button.onClick.Invoke();
    }
}
