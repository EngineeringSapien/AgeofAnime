using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Bot : MonoBehaviour {

    public GameObject p2Base;

    public score Score;
    public Age age;

    public buttonClick unit1Button;
    public buttonClick unit2Button;
    public buttonClick unit3Button;
    public buttonClick evolveButton;

    private int u1Count;
    private int u2Count;
    private int u3Count;

    private int button1Prob;
    private int button2Prob;
    private int button3Prob;


    private float botGold;
    private float unit1Cost;
    private float unit2Cost;
    private float unit3Cost;

    private bool canDecide = true;


    private void Update()
    {

        u1Count = p2Base.GetComponentInChildren<characterSpawner>().unit1BotsCount;
        u2Count = p2Base.GetComponentInChildren<characterSpawner>().unit2BotsCount;
        u3Count = p2Base.GetComponentInChildren<characterSpawner>().unit3BotsCount;

        botGold = Score.P2Gold;
        unit1Cost = Score.p2Unit1cost;
        unit2Cost = Score.p2Unit2cost;
        unit3Cost = Score.p2Unit3cost;

        if ((unit1Button._button.interactable == true || unit2Button._button.interactable == true || unit3Button._button.interactable == true) && canDecide == true)
        {
            if (age.P2Age == 2)
            {
                StartCoroutine(Delay(Random.Range(0, 4f)));
            }
            else if (age.P2Age == 3)
            {
                StartCoroutine(Delay(Random.Range(0, 4f)));
            }
            else
            {
                StartCoroutine(Delay(Random.Range(0, 5f)));
            }
        }

        if (evolveButton._button.interactable == true)
        {
            evolveButton.BotClick();
        }

    }

    IEnumerator Delay(float wait)
    {
        canDecide = false;
        yield return new WaitForSeconds(wait);

        ButtonProb();
    }

    private void ButtonProb()
    {
    
        button1Prob = 100;
        button2Prob = 100;
        button3Prob = 100;

        button1Prob -= (u1Count * 10);
        button2Prob -= (u2Count * 10);
        button3Prob -= (u3Count * 10);

        button1Prob += 10;
        button2Prob += 20;
        button3Prob += 30;

        int adjustment = Mathf.RoundToInt(botGold / unit1Cost);
        button1Prob += adjustment;
        int adjustment2 = Mathf.RoundToInt(botGold / unit2Cost);
        button2Prob += adjustment;   
        int adjustment3 = Mathf.RoundToInt(botGold / unit3Cost);
        button3Prob += adjustment;

        if (unit1Button._button.interactable == false)
        { button1Prob = 0; }
        if (unit2Button._button.interactable == false)
        { button2Prob = 0; }
        if (unit3Button._button.interactable == false)
        { button3Prob = 0; }

        SelectUnit(button1Prob, button2Prob, button3Prob);
    }



    void SelectUnit(int a, int b, int c)
    {
        int sum = a + b + c;

        int selection = Mathf.RoundToInt(Random.Range(0, sum-1));

        if (selection >= 0 && selection < a)
        { unit1Button.BotClick(); }

        else if (selection >= a && selection < (a + b))
        { unit2Button.BotClick(); }

        else if (selection >= (a + b) && selection < (a + b + c))
        { unit3Button.BotClick(); }

        else
        {
            Debug.Log("ERROR: Out of Range. --> " + selection);
        }

        canDecide = true;
    }

}
