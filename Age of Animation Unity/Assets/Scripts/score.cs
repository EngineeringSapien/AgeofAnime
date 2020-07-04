using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    public float P1EvolveReq;
    public float P2EvolveReq;

    public float expFactor = 2.5f;
    //public float expgoldReward = .8f;     // I don't think I am using this
    public float goldReward = 1.25f; 
    public float goldDeathReward = .20f; 

    public Age age;
    public ButtonSpriteManager Spawn;

    private string Char1 = "Character1";
    private string Char2 = "Character2";
    private string Char3 = "Character3";
    private string Char4 = "Character4";

    private List<float> unit1CostList = new List<float>();
    private List<float> unit2CostList = new List<float>();
    private List<float> unit3CostList = new List<float>();

    private List<float> evolveReqs = new List<float>();



    #region Call Backs
    private void Awake()
    {
        unit1CostList.AddRange(new float[] { 15, 120, 9000, 90000, 500000 });         // these numbers are the age of war 1 numbers
        unit2CostList.AddRange(new float[] { 30, 240, 20000, 200000, 750000 });
        unit3CostList.AddRange(new float[] { 100, 800, 70000, 700000, 1000000 });

        evolveReqs.AddRange(new float[] { 1200, 20000, 300000, 2000000, 1000000000 });
    }

    void Start()
    {
        P1Gold = 80;
        P2Gold = 150;

        p1Unit1cost = unit1CostList[0];
        p1Unit2cost = unit2CostList[0];
        p1Unit3cost = unit3CostList[0];

        p2Unit1cost = unit1CostList[0];
        p2Unit2cost = unit2CostList[0];
        p2Unit3cost = unit3CostList[0];

        P1Exp = 0;
        P2Exp = 0;

        P1EvolveReq = P2EvolveReq = evolveReqs[0];

    }
    #endregion


    private void Update()
    {
//        P1Exp = 10000000;

    }


    #region Changing Gold Reqs
    public void ChangeGoldReqs(string player, int age)   //for when players upgrade ages
    {
        if (player == "P1")
        {
            p1Unit1cost = unit1CostList[age];
            p1Unit2cost = unit2CostList[age];
            p1Unit3cost = unit3CostList[age];
        }

        if (player == "P2")
        {
            p2Unit1cost = unit1CostList[age];
            p2Unit2cost = unit2CostList[age];
            p2Unit3cost = unit3CostList[age];
        }
    }
    #endregion


    #region Changing Gold Treasury
    public void ChangeTreasury(string function, string name, string tag)
    {
        if (function == "increase")     //Increasing the gold after a unit is destroyed
        {
            if (tag == "Player2")
            {
                if (name == Char1) // if it is character 1
                {
                    P1Gold = P1Gold + (p1Unit1cost * goldReward);
                    P2Gold = P2Gold + (p2Unit1cost * goldDeathReward);
                }

                if (name == Char2) // if it is character 2
                {
                    P1Gold = P1Gold + (p1Unit2cost * goldReward);
                    P2Gold = P2Gold + (p2Unit2cost * goldDeathReward);
                }

                if (name == Char3) // if it is character 3
                {
                    P1Gold = P1Gold + (p1Unit3cost * goldReward);
                    P2Gold = P2Gold + (p2Unit3cost * goldDeathReward);
                }
            }

            if (tag == "Player1")
            {
                if (name == Char1) // if it is character 1
                {
                    P2Gold = P2Gold + (p2Unit1cost * goldReward * 2);
                    P1Gold = P1Gold + (p1Unit1cost * goldDeathReward);
                }

                if (name == Char2) // if it is character 2
                {
                    P2Gold = P2Gold + (p2Unit2cost * goldReward * 2);
                    P1Gold = P1Gold + (p1Unit2cost * goldDeathReward);
                }

                if (name == Char3) // if it is character 3
                {
                    P2Gold = P2Gold + (p2Unit3cost * goldReward * 2);
                    P1Gold = P1Gold + (p1Unit3cost * goldDeathReward);
                }
            }
        }
        
        if (function == "decrease")     //decreasing the gold if a unit is purchased
        {
            if (tag == "Player1")
            {
                if (name == Char1) // if it is character 1
                {
                    P1Gold = P1Gold - p1Unit1cost;
                }

                if (name == Char2) // if it is character 2
                {
                    P1Gold = P1Gold - (p1Unit2cost);
                }

                if (name == Char3) // if it is character 3
                {
                    P1Gold = P1Gold - (p1Unit3cost);
                }
            }

            if (tag == "Player2")
            {
                if (name == Char1) // if it is character 1
                {
                    P2Gold = P2Gold - (p2Unit1cost);
                }

                if (name == Char2) // if it is character 2
                {
                    P2Gold = P2Gold - (p2Unit2cost);
                }

                if (name == Char3) // if it is character 3
                {
                    P2Gold = P2Gold - (p2Unit3cost);
                }
            }




        }
    }
    #endregion


    #region Changing Experience Reqs
    public void ChangeExperienceReqs(string player, int age)
    {

        if (player == "P1")
        {
            P1EvolveReq = evolveReqs[age];
        }

        if (player == "P2")
        {
            P2EvolveReq = evolveReqs[age];
        }
    }
    #endregion


    #region Changing Experience
    public void ChangeExperience(string function, string name, string tag)
    {

        if (function == "increase")
        {
            if (tag == "Player2")
            {
                if (name == Char1) // if it is character 1
                {
                    P1Exp = P1Exp + (p1Unit1cost * expFactor);
                    P2Exp = P2Exp + (p2Unit1cost * expFactor / 3);
                }

                if (name == Char2) // if it is character 2
                {
                    P1Exp = P1Exp + (p1Unit2cost * expFactor);
                    P2Exp = P2Exp + (p2Unit2cost * expFactor / 3);
                }

                if (name == Char3) // if it is character 3
                {
                    P1Exp = P1Exp + (p1Unit3cost * expFactor);
                    P2Exp = P2Exp + (p2Unit3cost * expFactor / 3);
                }

                else
                {
                }
            }

            if (tag == "Player1")
            {
                if (name == Char1) // if it is character 1
                {
                    P2Exp = P2Exp + (p2Unit1cost * expFactor);
                    P1Exp = P1Exp + (p1Unit1cost * expFactor / 3);
                }

                if (name == Char2) // if it is character 2
                {
                    P2Exp = P2Exp + (p2Unit2cost * expFactor);
                    P1Exp = P1Exp + (p1Unit2cost * expFactor / 3);
                }

                if (name == Char3) // if it is character 3
                {
                    P2Exp = P2Exp + (p2Unit3cost * expFactor);
                    P1Exp = P1Exp + (p1Unit3cost * expFactor / 3);
                }
            }
        }


        if (function == "decrease")
        {
            if (tag == "P1")
            {
                P1Exp = 0;
            }

            if (tag == "P2")
            {
                P2Exp = 0;
            }
        }
    }
    #endregion
}