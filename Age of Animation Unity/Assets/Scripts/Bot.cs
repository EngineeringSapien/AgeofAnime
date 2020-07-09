using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Bot : MonoBehaviour {

    public characterSpawner p2Spawner;

    public score scoreManager;
    public Age age;

    public buttonClick unit1Button;
    public buttonClick unit2Button;
    public buttonClick unit3Button;
    public buttonClick evolveButton;

    private int button1Prob;
    private int button2Prob;
    private int button3Prob;

    private bool canDecide = true;


    private void Update()
    {
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

        button1Prob -= (p2Spawner.unit1BotsCount * 10);
        button2Prob -= (p2Spawner.unit2BotsCount * 10);
        button3Prob -= (p2Spawner.unit3BotsCount * 10);

        button1Prob += 10;
        button2Prob += 20;
        button3Prob += 30;

        int adjustment = Mathf.RoundToInt(scoreManager.P2Gold / scoreManager.p2Unit1cost);
        button1Prob += adjustment;
        int adjustment2 = Mathf.RoundToInt(scoreManager.P2Gold / scoreManager.p2Unit2cost);
        button2Prob += adjustment;   
        int adjustment3 = Mathf.RoundToInt(scoreManager.P2Gold / scoreManager.p2Unit3cost);
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

        canDecide = true;
    }

}
