using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Age : MonoBehaviour {

    public int P1Age;
    public int P2Age;
    public int globalAge;

    public environment env;
    public baseHealth P1baseHealth;
    public baseHealth P2baseHealth;
    public Units units;
    public score Score;


    // Use this for initialization
    private void Awake()
    {
        P1Age = 0;
        P2Age = 0;
        globalAge = 0;
    }
	
	// Update is called once per frame
	void Update () {

//        Debug.Log("Player 1 age: " + P1Age);
  //      Debug.Log("Player 2 age: " + P2Age);
    //    Debug.Log("global age: " + globalAge);
        if (P1Age > P2Age)
        {
            globalAge = P1Age;
        }
        if (P2Age > P1Age)
        {
            globalAge = P2Age;
        }
        else
        {
            globalAge = P1Age;
        }
		
	}


    public void ChangeAge(string player)
    {
        //Debug.Log("Age before change " + globalAge);
        if (player == "P1")
        {
            P1Age++;
            Update();
            env.ChangeBackground(globalAge);
            env.ChangeBases("P1", P1Age);
            units.ChangeUnits("P1", P1Age);
            P1baseHealth.ResetHealth(1);
            Score.ChangeGoldReqs("P1", P1Age);
            Score.ChangeExperienceReqs("P1", P1Age);
            Score.ChangeExperience("decrease", "n/a", "P1");
        }
        if (player == "P2")
        {
            P2Age++;
            Update();
            env.ChangeBackground(globalAge);
            env.ChangeBases("P2", P2Age);
            units.ChangeUnits("P2", P2Age);
            P2baseHealth.ResetHealth(2);
            Score.ChangeGoldReqs("P2", P2Age);
            Score.ChangeExperienceReqs("P2", P2Age);
            Score.ChangeExperience("decrease", "n/a", "P2");

        }

    }


}
