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

    public Units unitManager;


    void Start()
    {
        P1Gold = 80;
        P2Gold = 150;

        p1Unit1cost = unitManager.eachUnit1Cost[0];
        p1Unit2cost = unitManager.eachUnit2Cost[0];
        p1Unit3cost = unitManager.eachUnit3Cost[0];

        p2Unit1cost = unitManager.eachUnit1Cost[0];
        p2Unit2cost = unitManager.eachUnit2Cost[0];
        p2Unit3cost = unitManager.eachUnit3Cost[0];

        P1Exp = 0;
        P2Exp = 0;

        P1EvolveXPCost = P2EvolveXPCost = unitManager.eachAgeEvolveXPCost[0];
    }


    public void ChangeGoldReqs(string player, int age)
    {
        if (player == "P1")
        {
            p1Unit1cost = unitManager.eachUnit1Cost[age];
            p1Unit2cost = unitManager.eachUnit2Cost[age];
            p1Unit3cost = unitManager.eachUnit3Cost[age];
        }

        if (player == "P2")
        {
            p2Unit1cost = unitManager.eachUnit1Cost[age];
            p2Unit2cost = unitManager.eachUnit2Cost[age];
            p2Unit3cost = unitManager.eachUnit3Cost[age];
        }
    }


    public void ChangeTreasury(string change, string unitName, string player)
    {
        if (change == "increase")
        {
            if (player == "Player2")
            {
                if (unitName == unitManager.unit1SpawnName)
                {
                    P1Gold = P1Gold + (p1Unit1cost * unitKilledGoldReward);
                    P2Gold = P2Gold + (p2Unit1cost * unitDeathGoldReward);
                }

                if (unitName == unitManager.unit2SpawnName)
                {
                    P1Gold = P1Gold + (p1Unit2cost * unitKilledGoldReward);
                    P2Gold = P2Gold + (p2Unit2cost * unitDeathGoldReward);
                }

                if (unitName == unitManager.unit3SpawnName)
                {
                    P1Gold = P1Gold + (p1Unit3cost * unitKilledGoldReward);
                    P2Gold = P2Gold + (p2Unit3cost * unitDeathGoldReward);
                }
            }

            if (player == "Player1")
            {
                if (unitName == unitManager.unit1SpawnName)
                {
                    P2Gold = P2Gold + (p2Unit1cost * unitKilledGoldReward * 2);
                    P1Gold = P1Gold + (p1Unit1cost * unitDeathGoldReward);
                }

                if (unitName == unitManager.unit2SpawnName)
                {
                    P2Gold = P2Gold + (p2Unit2cost * unitKilledGoldReward * 2);
                    P1Gold = P1Gold + (p1Unit2cost * unitDeathGoldReward);
                }

                if (unitName == unitManager.unit3SpawnName)
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
                if (unitName == unitManager.unit1SpawnName) 
                {
                    P1Gold = P1Gold - p1Unit1cost;
                }

                if (unitName == unitManager.unit2SpawnName)
                {
                    P1Gold = P1Gold - (p1Unit2cost);
                }

                if (unitName == unitManager.unit3SpawnName)
                {
                    P1Gold = P1Gold - (p1Unit3cost);
                }
            }

            if (player == "Player2")
            {
                if (unitName == unitManager.unit1SpawnName)
                {
                    P2Gold = P2Gold - (p2Unit1cost);
                }

                if (unitName == unitManager.unit2SpawnName)
                {
                    P2Gold = P2Gold - (p2Unit2cost);
                }

                if (unitName == unitManager.unit3SpawnName)
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
            P1EvolveXPCost = unitManager.eachAgeEvolveXPCost[age];
        }

        if (player == "P2")
        {
            P2EvolveXPCost = unitManager.eachAgeEvolveXPCost[age];
        }
    }


    public void ChangeExperience(string change, string unitName, string player)
    {
        if (change == "increase")
        {
            if (player == "Player2")
            {
                if (unitName == unitManager.unit1SpawnName)
                {
                    P1Exp = P1Exp + (p1Unit1cost * unitKilledXPReward);
                    P2Exp = P2Exp + (p2Unit1cost * unitDeathXPReward);
                }

                if (unitName == unitManager.unit2SpawnName)
                {
                    P1Exp = P1Exp + (p1Unit2cost * unitKilledXPReward);
                    P2Exp = P2Exp + (p2Unit2cost * unitDeathXPReward);
                }

                if (unitName == unitManager.unit3SpawnName)
                {
                    P1Exp = P1Exp + (p1Unit3cost * unitKilledXPReward);
                    P2Exp = P2Exp + (p2Unit3cost * unitDeathXPReward);
                }
            }

            if (player == "Player1")
            {
                if (unitName == unitManager.unit1SpawnName)
                {
                    P2Exp = P2Exp + (p2Unit1cost * unitKilledXPReward);
                    P1Exp = P1Exp + (p1Unit1cost * unitDeathXPReward);
                }

                if (unitName == unitManager.unit2SpawnName)
                {
                    P2Exp = P2Exp + (p2Unit2cost * unitKilledXPReward);
                    P1Exp = P1Exp + (p1Unit2cost * unitDeathXPReward);
                }

                if (unitName == unitManager.unit3SpawnName)
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