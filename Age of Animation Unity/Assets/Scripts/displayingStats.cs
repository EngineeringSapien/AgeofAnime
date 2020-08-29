using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayingStats : MonoBehaviour {

    public Text goldText;
    public Text expText;
    public Text evolveCostText;


    private void Start()
    {
        if (gameObject.layer == 10)
        {
            ChangeEvolveText(4000);
            ChangeGoldText(175);
            ChangeXPText(0);
        }
    }


    public void ChangeEvolveText(float evolveCost)
    {
        evolveCostText.text = evolveCost.ToString();
    }


    public void ChangeGoldText(float gold)
    {
        goldText.text = Mathf.RoundToInt(gold).ToString();
    }


    public void ChangeXPText(float XP)
    {
        expText.text = Mathf.RoundToInt(XP).ToString();
    }
}
