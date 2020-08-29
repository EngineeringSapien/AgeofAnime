using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayingStats : MonoBehaviour {

    public Text goldText;
    public Text expText;
    public Text evolveCostText;

    //public score Score;


    private void Start()
    {
        if (gameObject.layer == 10)
        {
            ChangeEvolveText(1400);
            ChangeGoldText(150);
            ChangeXPText(0);
        }
    }


    void Update ()
    {

        //if (this.gameObject.name == "P1 Health, Experience, Gold Parent")
        //{
        //    goldText.text = Mathf.RoundToInt(Score.P1Gold).ToString();
        //    expText.text = Mathf.RoundToInt(Score.P1Exp).ToString();
        //    //evolveCostText.text = Score.P1EvolveXPCost.ToString();
        //}
        //else if (this.gameObject.name == "P2 Health, Experience, Gold Parent")
        //{
        //    goldText.text = Mathf.RoundToInt(Score.P2Gold).ToString();
        //    expText.text = Mathf.RoundToInt(Score.P2Exp).ToString();
        //}

    }


    public void ChangeEvolveText(float evolveCost)
    {
        evolveCostText.text = evolveCost.ToString();
    }


    public void ChangeGoldText(float gold)
    {
        goldText.text = gold.ToString();
    }


    public void ChangeXPText(float XP)
    {
        expText.text = XP.ToString();
    }
}
