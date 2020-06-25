using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayingStats : MonoBehaviour {

    public Text healthText;
    public baseHealth Health;

    public Text goldText;
    public Text expText;
    public score Score;
    
    
	void Start ()
    {
        // I could probably get rid of the public references by just finding the objects in the children
    }


    void Update ()
    {
        healthText.text = "Health: " + Health.currentHealth;                   //If statement to check player not needed b/c we make the reference directly in the editor

        if (this.gameObject.name == "P1 Health, Experience, Gold Parent")   //*We DO need if statements for the gold and experience values because the gold/score for both players sit on the same gameObject/script
        {
            goldText.text = "P1 Gold: " + Score.P1Gold;
        }
        else if (this.gameObject.name == "P2 Health, Experience, Gold Parent")
        {
            goldText.text = "P2 Gold: " + Score.P2Gold;
        }


        if (this.gameObject.name == "P1 Health, Experience, Gold Parent")   //*See above
        {
            expText.text = "P1 Exp: " + Score.P1Exp;
        }
        else if (this.gameObject.name == "P2 Health, Experience, Gold Parent")
        {
            expText.text = "P2 Exp: " + Score.P2Exp;
        }
    }
}
