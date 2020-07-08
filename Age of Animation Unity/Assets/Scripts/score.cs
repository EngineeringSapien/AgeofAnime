using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class score : MonoBehaviour
{

    public float P1Gold;
    public float P2Gold;
    public float P1Exp;
    public float P2Exp;

    public float p1Unit1cost;
    public float p1Unit2cost;
    public float p1Unit3cost;

    public float p2Unit1cost;
    public float p2Unit2cost;
    public float p2Unit3cost;

    public float P1EvolveXPCost;
    public float P2EvolveXPCost;

    private float unitKilledXPReward = 2.5f;
    private float unitDeathXPReward = 0.8f;
    private float unitKilledGoldReward = 1.25f;
    private float unitDeathGoldReward = 0.1f; 

    private string unit1Name = "Character1";
    private string unit2Name = "Character2";
    private string unit3Name = "Character3";

    private List<float> eachUnit1Cost = new List<float>();
    private List<float> eachUnit2Cost = new List<float>();
    private List<float> eachUnit3Cost = new List<float>();

    private List<float> eachAgeEvolveXPCost = new List<float>();


    private void Awake()
    {
        eachUnit1Cost.AddRange(new float[] { 15, 120, 9000, 90000, 500000 });         // these numbers are the age of war 1 numbers
        eachUnit2Cost.AddRange(new float[] { 30, 240, 20000, 200000, 750000 });
        eachUnit3Cost.AddRange(new float[] { 100, 800, 70000, 700000, 1000000 });

        eachAgeEvolveXPCost.AddRange(new float[] { 1200, 20000, 300000, 2000000, 1000000000 });
    }


    void Start()
    {
        P1Gold = 80;
        P2Gold = 150;

        p1Unit1cost = eachUnit1Cost[0];
        p1Unit2cost = eachUnit2Cost[0];
        p1Unit3cost = eachUnit3Cost[0];

        p2Unit1cost = eachUnit1Cost[0];
        p2Unit2cost = eachUnit2Cost[0];
        p2Unit3cost = eachUnit3Cost[0];

        P1Exp = 0;
        P2Exp = 0;

        P1EvolveXPCost = P2EvolveXPCost = eachAgeEvolveXPCost[0];
    }


    public void ChangeGoldReqs(string player, int age)
    {
        if (player == "P1")
        {
            p1Unit1cost = eachUnit1Cost[age];
            p1Unit2cost = eachUnit2Cost[age];
            p1Unit3cost = eachUnit3Cost[age];
        }

        if (player == "P2")
        {
            p2Unit1cost = eachUnit1Cost[age];
            p2Unit2cost = eachUnit2Cost[age];
            p2Unit3cost = eachUnit3Cost[age];
        }
    }


    public void ChangeTreasury(string change, string unitName, string player)
    {
        if (change == "increase")
        {
            if (player == "Player2")
            {
                if (unitName == unit1Name)
                {
                    P1Gold = P1Gold + (p1Unit1cost * unitKilledGoldReward);
                    P2Gold = P2Gold + (p2Unit1cost * unitDeathGoldReward);
                }

                if (unitName == unit2Name)
                {
                    P1Gold = P1Gold + (p1Unit2cost * unitKilledGoldReward);
                    P2Gold = P2Gold + (p2Unit2cost * unitDeathGoldReward);
                }

                if (unitName == unit3Name)
                {
                    P1Gold = P1Gold + (p1Unit3cost * unitKilledGoldReward);
                    P2Gold = P2Gold + (p2Unit3cost * unitDeathGoldReward);
                }
            }

            if (player == "Player1")
            {
                if (unitName == unit1Name)
                {
                    P2Gold = P2Gold + (p2Unit1cost * unitKilledGoldReward * 2);
                    P1Gold = P1Gold + (p1Unit1cost * unitDeathGoldReward);
                }

                if (unitName == unit2Name)
                {
                    P2Gold = P2Gold + (p2Unit2cost * unitKilledGoldReward * 2);
                    P1Gold = P1Gold + (p1Unit2cost * unitDeathGoldReward);
                }

                if (unitName == unit3Name)
                {
                    P2Gold = P2Gold + (p2Unit3cost * unitKilledGoldReward * 2);
                    P1Gold = P1Gold + (p1Unit3cost * unitDeathGoldReward);
                }
            }
        }
        
        if (change == "decrease")
        {
            if (player == "Player1")
            {
                if (unitName == unit1Name) 
                {
                    P1Gold = P1Gold - p1Unit1cost;
                }

                if (unitName == unit2Name)
                {
                    P1Gold = P1Gold - (p1Unit2cost);
                }

                if (unitName == unit3Name)
                {
                    P1Gold = P1Gold - (p1Unit3cost);
                }
            }

            if (player == "Player2")
            {
                if (unitName == unit1Name)
                {
                    P2Gold = P2Gold - (p2Unit1cost);
                }

                if (unitName == unit2Name)
                {
                    P2Gold = P2Gold - (p2Unit2cost);
                }

                if (unitName == unit3Name)
                {
                    P2Gold = P2Gold - (p2Unit3cost);
                }
            }
        }
    }


    public void ChangeExperienceReqs(string player, int age)
    {
        if (player == "P1")
        {
            P1EvolveXPCost = eachAgeEvolveXPCost[age];
        }

        if (player == "P2")
        {
            P2EvolveXPCost = eachAgeEvolveXPCost[age];
        }
    }


    public void ChangeExperience(string change, string unitName, string player)
    {
        if (change == "increase")
        {
            if (player == "Player2")
            {
                if (unitName == unit1Name)
                {
                    P1Exp = P1Exp + (p1Unit1cost * unitKilledXPReward);
                    P2Exp = P2Exp + (p2Unit1cost * unitDeathXPReward);
                }

                if (unitName == unit2Name)
                {
                    P1Exp = P1Exp + (p1Unit2cost * unitKilledXPReward);
                    P2Exp = P2Exp + (p2Unit2cost * unitDeathXPReward);
                }

                if (unitName == unit3Name)
                {
                    P1Exp = P1Exp + (p1Unit3cost * unitKilledXPReward);
                    P2Exp = P2Exp + (p2Unit3cost * unitDeathXPReward);
                }
            }

            if (player == "Player1")
            {
                if (unitName == unit1Name)
                {
                    P2Exp = P2Exp + (p2Unit1cost * unitKilledXPReward);
                    P1Exp = P1Exp + (p1Unit1cost * unitDeathXPReward);
                }

                if (unitName == unit2Name)
                {
                    P2Exp = P2Exp + (p2Unit2cost * unitKilledXPReward);
                    P1Exp = P1Exp + (p1Unit2cost * unitDeathXPReward);
                }

                if (unitName == unit3Name)
                {
                    P2Exp = P2Exp + (p2Unit3cost * unitKilledXPReward);
                    P1Exp = P1Exp + (p1Unit3cost * unitDeathXPReward);
                }
            }
        }

        if (change == "decrease")
        {
            if (player == "P1")
            {
                P1Exp = 0;
            }

            if (player == "P2")
            {
                P2Exp = 0;
            }
        }
    }

}