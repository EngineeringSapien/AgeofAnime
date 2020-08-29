using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayingStats : MonoBehaviour {

    public Text goldText;
    public Text expText;
    public Text evolveCostText;

    public score Score;


    void Update ()
    {

        if (this.gameObject.name == "P1 Health, Experience, Gold Parent")
        {
            goldText.text = Mathf.RoundToInt(Score.P1Gold).ToString();
            expText.text = Mathf.RoundToInt(Score.P1Exp).ToString();
            evolveCostText.text = Score.P1EvolveXPCost.ToString();
        }
        else if (this.gameObject.name == "P2 Health, Experience, Gold Parent")
        {
            goldText.text = Mathf.RoundToInt(Score.P2Gold).ToString();
            expText.text = Mathf.RoundToInt(Score.P2Exp).ToString();
        }

    }
}
