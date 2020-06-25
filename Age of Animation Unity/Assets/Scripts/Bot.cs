using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour {


    public GameObject p2Base;

    private int u1Count;
    private int u2Count;
    private int u3Count;

    private int button1Prob;
    private int button2Prob;
    private int button3Prob;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    buttonClick click1;
    buttonClick click2;
    buttonClick click3;
    buttonClick click4;

    public score Score;
    public Age age;
    private float botGold;
    private float unit1Cost;
    private float unit2Cost;
    private float unit3Cost;

    private bool canDecide = true;



    private void Awake()
    {
        click1 = button1.GetComponent<buttonClick>();
        click2 = button2.GetComponent<buttonClick>();
        click3 = button3.GetComponent<buttonClick>();
        click4 = button4.GetComponent<buttonClick>();
    }

    private void Update()
    {

        u1Count = p2Base.GetComponentInChildren<characterSpawner>().unit1Count;
        u2Count = p2Base.GetComponentInChildren<characterSpawner>().unit2Count;
        u3Count = p2Base.GetComponentInChildren<characterSpawner>().unit3Count;

        botGold = Score.P2Gold;
        unit1Cost = Score.p2Unit1cost;
        unit2Cost = Score.p2Unit2cost;
        unit3Cost = Score.p2Unit3cost;

        if ((click1._button.interactable == true || click2._button.interactable == true || click3._button.interactable == true) && canDecide == true)
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

        if (click4._button.interactable == true)
        {
            click4.Click();
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

        Debug.Log("1 Count: " + u1Count);
        Debug.Log("2 Count: " + u2Count);
        Debug.Log("3 Count: " + u3Count);

        //Adjust based on # of units on field
        button1Prob -= (u1Count * 10);
        button2Prob -= (u2Count * 10);
        button3Prob -= (u3Count * 10);

        //Adjust based on strength of each unit
        button1Prob += 10;
        button2Prob += 20;
        button3Prob += 30;

        //Adjust based on gold cost of unit
        int adjustment = Mathf.RoundToInt(botGold / unit1Cost);
        button1Prob += adjustment;
        int adjustment2 = Mathf.RoundToInt(botGold / unit2Cost);
        button1Prob += adjustment;   
        int adjustment3 = Mathf.RoundToInt(botGold / unit3Cost);
        button1Prob += adjustment;

        if (click3._button.interactable == false)
        { button3Prob = 0; }
        if (click2._button.interactable == false)
        { button2Prob = 0; }
        if (click1._button.interactable == false)
        { button1Prob = 0; }

        Debug.Log("Unit1 Prob: " + button1Prob);
        Debug.Log("Unit2 Prob: " + button2Prob);
        Debug.Log("Unit3 Prob: " + button3Prob);

        Debug.Log("click1: " + click1._button.interactable);
        Debug.Log("click2: " + click2._button.interactable);
        Debug.Log("click3: " + click3._button.interactable);

        SelectUnit(button1Prob, button2Prob, button3Prob);


    }



    void SelectUnit(int a, int b, int c)
    {
        int sum = a + b + c;

        int selection = Mathf.RoundToInt(Random.Range(0, sum-1));

        if (selection > 0 && selection < a)
        { click1.Click(); }
        else if (selection >= a && selection < (a + b))
        { click2.Click(); }
        else if (selection >= b && selection < (a + b + c))
        { click3.Click(); }
        else
        {
            //Debug.Log("ERROR: Out of Range");
        }
        canDecide = true;
    }


// Function for deciding what to do with units: 
    void UnitProb()
    {
        //determine which units are spawnable
            //check which buttons are enabled
                //reference buttons[n].interactable from spawn.cs


        //adjust unit probabilities based on conditional statements of game events
            /*
             * #Assigning zero probz to non-interactable units
             * for i in range(3):
             *  if (button[i].interactable = false)
             *      unitP[i] = 0
             *  
             *  else
             *      unitP[i] = 100 / numberofinteractableUnits
             * 
             * 
             * #Adjusting based on units on screen
             *for i in range(3):
             * FindObjectofType(Unit[i])         #I have no idea how this is actually going to work
             * if found unit[i]:                 #unit = [character1, character2, character3]
             *  unitOnField[i] += 1              #unitOnField = unit1s, unit2s, unit3s  or  list = list1, list2, list3
             *
             *for i in range(unitOnField):
             *  unitP[i] -= (unitOnField[i] * 10)            #subtracting 10 from each respective unit for each respective unit on field
             *  
             *  
             *#Adjusting based on unit strength
             * for i in range(interactableUnit):
             *  maxUnitStrength = 0
             *  if (interactableUnit[i].Strength > maxUnitStrength)
             *      maxUnitStrength = interactableUnit[i].Strength
             *      unitP[i] += 20
             *  elif (interactableUnit[i].S < maxUnitStrength)
             *      unitP[i] -= 20 
             *      
                      
         */

    }



}
