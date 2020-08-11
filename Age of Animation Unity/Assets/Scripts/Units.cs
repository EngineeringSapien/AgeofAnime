using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour {

    public GameObject P1character1;
    public GameObject P1character2;
    public GameObject P1character3;

    public GameObject P2character1;
    public GameObject P2character2;
    public GameObject P2character3;

    public List<string> unit1Characters = new List<string>();
    public List<string> unit2Characters = new List<string>();
    public List<string> unit3Characters = new List<string>();

    public string unit1SpawnName = "Character1";
    public string unit2SpawnName = "Character2";
    public string unit3SpawnName = "Character3";

    public List<float> eachUnit1Damage = new List<float>();
    public List<float> eachUnit2Damage = new List<float>();
    public List<float> eachUnit3Damage = new List<float>();

    public List<float> eachUnit2RangeDamage = new List<float>();
    public List<float> eachUnit3RangeDamage = new List<float>();

    public List<float> eachUnit1Spawntime = new List<float>();
    public List<float> eachUnit2Spawntime = new List<float>();
    public List<float> eachUnit3Spawntime = new List<float>();

    public List<float> eachUnit1Health = new List<float>();
    public List<float> eachUnit2Health = new List<float>();
    public List<float> eachUnit3Health = new List<float>();

    public List<float> eachUnit1Speed = new List<float>();
    public List<float> eachUnit2Speed = new List<float>();
    public List<float> eachUnit3Speed = new List<float>();

    public List<float> eachUnit1MeleeDistance = new List<float>();
    public List<float> eachUnit2MeleeDistance = new List<float>();
    public List<float> eachUnit3MeleeDistance = new List<float>();

    public List<float> eachUnit1RangeDistance = new List<float>();
    public List<float> eachUnit2RangeDistance = new List<float>();
    public List<float> eachUnit3RangeDistance = new List<float>();

    public List<float> eachUnit1Cost = new List<float>();
    public List<float> eachUnit2Cost = new List<float>();
    public List<float> eachUnit3Cost = new List<float>();
    
    public List<float> eachAgeEvolveXPCost = new List<float>();



    private void Awake()
    {
        eachAgeEvolveXPCost.AddRange(new float[] { 4000, 14000, 45000, 200000, 1000000000 });

        unit1Characters.AddRange(new string[] {"Kakashi", "4th Hokage", "Vegeta", "Rukia", "Eric FullMetal" });
        unit2Characters.AddRange(new string[] {"Itachi", "Pain", "Goku", "Ichigo", "Colonel Mustang" });
        unit3Characters.AddRange(new string[] {"Zabuza", "Sage Mode Naruto", "Frieza", "Byakuya", "Fuhrer Bradley" });

        eachUnit1Cost.AddRange(new float[] { 15, 50, 200, 1500, 5000 });         // these numbers are the age of war 1 numbers
        eachUnit2Cost.AddRange(new float[] { 25, 75, 400, 2000, 6000 });
        eachUnit3Cost.AddRange(new float[] { 100, 500, 1000, 70000, 20000 });

        eachUnit1Damage.AddRange(new float[] { 30, 45, 102, 130, 234 });             
        eachUnit2Damage.AddRange(new float[] { 12, 25, 40, 75, 150 });             
        eachUnit3Damage.AddRange(new float[] { 50, 75, 105, 260, 150 });

        eachUnit2RangeDamage.AddRange(new float[] { 10, 11, 25, 100, 150 });             
        eachUnit3RangeDamage.AddRange(new float[] { 10, 11, 25, 200, 75 });

        eachUnit1Health.AddRange(new float[] { 55*1.25f, 95*1.25f, 184*1.25f, 346, 623 });       
        eachUnit2Health.AddRange(new float[] { 44*1.25f, 8*1.25f, 153*1.25f, 312, 561 });      
        eachUnit3Health.AddRange(new float[] { 160, 261, 602, 1211, 2180});

        eachUnit1Spawntime.AddRange(new float[] { .6f, .80f, 1.06f, 1.41f, 1.88f});
        eachUnit2Spawntime.AddRange(new float[] { .5f, .67f, .88f, 1.18f, 1.56f});
        eachUnit3Spawntime.AddRange(new float[] { 1.5f, 2f, 2.66f, 3.53f, 4.69f });

        eachUnit1Speed.AddRange(new float[] { 1f, 3f, 2, 1f, 1f });
        eachUnit2Speed.AddRange(new float[] { 1, 1, 2, 1.5f, 1f });
        eachUnit3Speed.AddRange(new float[] { 1, 1.3f, 2, 1f, 2f });

        eachUnit1MeleeDistance.AddRange(new float[] { .5f, .75f, .5f, .5f, .75f });
        eachUnit2MeleeDistance.AddRange(new float[] { .75f, 1.5f, .1f, .75f, 1f });
        eachUnit3MeleeDistance.AddRange(new float[] { .25f, .5f, .5f, .5f, 1.25f });
        
        eachUnit1RangeDistance.AddRange(new float[] { 1, 1, 1, 1, 1 });
        eachUnit2RangeDistance.AddRange(new float[] { 25, 30, 25, 25, 20 });
        eachUnit3RangeDistance.AddRange(new float[] { 25, 30, 25, 25, 25 });


        P1character1 = (Resources.Load(unit1Characters[0]) as GameObject);
        P1character2 = (Resources.Load(unit2Characters[0]) as GameObject);
        P1character3 = (Resources.Load(unit3Characters[0]) as GameObject);

        P2character1 = (Resources.Load(unit1Characters[0]) as GameObject);
        P2character2 = (Resources.Load(unit2Characters[0]) as GameObject);
        P2character3 = (Resources.Load(unit3Characters[0]) as GameObject);

    }


    public void ChangeUnits(string player, int age)
    {
        if (player == "P1")
        {
            P1character1 = (Resources.Load(unit1Characters[age]) as GameObject);
            P1character2 = (Resources.Load(unit2Characters[age]) as GameObject);
            P1character3 = (Resources.Load(unit3Characters[age]) as GameObject);
        }

        else if (player == "P2")
        {
            P2character1 = (Resources.Load(unit1Characters[age]) as GameObject);
            P2character2 = (Resources.Load(unit2Characters[age]) as GameObject);
            P2character3 = (Resources.Load(unit3Characters[age]) as GameObject);
        }
    }



}
