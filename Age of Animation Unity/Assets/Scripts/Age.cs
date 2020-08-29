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
    public displayingStats statDisplayer;


    private void Awake()
    {
        P1Age = 0;
        P2Age = 0;
        globalAge = 0;
    }


    public void ChangeAge(string player)
    {
        if (player == "P1")
        {
            P1Age++;
            ChangeGlobalAge();
            env.ChangeBases("P1", P1Age);
            units.ChangeUnits("P1", P1Age);
            P1baseHealth.ResetHealth(1);
            Score.ChangeGoldReqs("P1", P1Age);
            Score.ChangeExperienceReqs("P1", P1Age);
            Score.ChangeExperience("decrease", "n/a", "P1");
            statDisplayer.ChangeEvolveText(Score.P1EvolveXPCost);
        }

        if (player == "P2")
        {
            P2Age++;
            ChangeGlobalAge();
            env.ChangeBases("P2", P2Age);
            units.ChangeUnits("P2", P2Age);
            P2baseHealth.ResetHealth(2);
            Score.ChangeGoldReqs("P2", P2Age);
            Score.ChangeExperienceReqs("P2", P2Age);
            Score.ChangeExperience("decrease", "n/a", "P2");
        }
    }


    void ChangeGlobalAge()
    {
        if (P1Age > P2Age)
        { globalAge = P1Age; }

        if (P2Age > P1Age)
        { globalAge = P2Age; }

        else
        { globalAge = P1Age; }
    }

}