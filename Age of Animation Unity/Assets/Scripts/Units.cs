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

    public List<int> eachUnit1Damage = new List<int>();
    public List<int> eachUnit2Damage = new List<int>();
    public List<int> eachUnit3Damage = new List<int>();

    public List<int> eachUnit2RangeDamage = new List<int>();
    public List<int> eachUnit3RangeDamage = new List<int>();

    public List<float> eachUnit1Spawntime = new List<float>();
    public List<float> eachUnit2Spawntime = new List<float>();
    public List<float> eachUnit3Spawntime = new List<float>();

    public List<float> eachUnit1Health = new List<float>();
    public List<float> eachUnit2Health = new List<float>();
    public List<float> eachUnit3Health = new List<float>();

    public List<float> eachUnit1Speed = new List<float>();
    public List<float> eachUnit2Speed = new List<float>();
    public List<float> eachUnit3Speed = new List<float>();

    public List<float> eachUnit1Range = new List<float>();
    public List<float> eachUnit2Range = new List<float>();
    public List<float> eachUnit3Range = new List<float>();

    public List<float> eachUnit1Cost = new List<float>();
    public List<float> eachUnit2Cost = new List<float>();
    public List<float> eachUnit3Cost = new List<float>();
    
    public List<float> eachAgeEvolveXPCost = new List<float>();



    private void Awake()
    {
        unit1Characters.AddRange(new string[] {"Kakashi", "4th Hokage", "Vegeta", "Rukia", "Eric FullMetal" });
        unit2Characters.AddRange(new string[] {"Itachi", "Pain", "Goku", "Ichigo", "Colonel Mustang" });
        unit3Characters.AddRange(new string[] {"Zabuza", "Sage Mode Naruto", "Frieza", "Byakuya", "Fuhrer Bradley" });

        eachUnit1Damage.AddRange(new int[] { 15, 35, 35, 60, 90 });             
        eachUnit2Damage.AddRange(new int[] { 8, 15, 35, 40, 70 });             
        eachUnit3Damage.AddRange(new int[] { 48, 50, 60, 110, 90 });

        eachUnit2RangeDamage.AddRange(new int[] { 20, 30, 50, 60, 150 });             
        eachUnit3RangeDamage.AddRange(new int[] { 12, 80, 80, 120, 90 });

        eachUnit1Spawntime.AddRange(new float[] { 1f, 1.5f, 2f, 2.5f, 3f});
        eachUnit2Spawntime.AddRange(new float[] { 1.2f, 1.7f, 2.3f, 2.8f, 3.2f});
        eachUnit3Spawntime.AddRange(new float[] { 3f, 3.33f, 3.66f, 4f, 5f });

        eachUnit1Health.AddRange(new float[] { 100f, 80f, 115f, 180f, 240f });       
        eachUnit2Health.AddRange(new float[] { 80f, 100f, 130f, 200f, 240f });      
        eachUnit3Health.AddRange(new float[] { 100f, 150f, 180f, 350f, 700f });

        eachUnit1Speed.AddRange(new float[] { 1f, 3f, 2, 1f, 1f });
        eachUnit2Speed.AddRange(new float[] { 1, 1, 2, 1.5f, 1f });
        eachUnit3Speed.AddRange(new float[] { 1, 1.3f, 2, 1f, 2f });
        
        eachUnit1Range.AddRange(new float[] { 1, 1, 1, 1, 1 });
        eachUnit2Range.AddRange(new float[] { 25, 25, 25, 25, 25 });
        eachUnit3Range.AddRange(new float[] { 25, 25, 25, 25, 25 });

        eachUnit1Cost.AddRange(new float[] { 15, 120, 9000, 90000, 500000 });         // these numbers are the age of war 1 numbers
        eachUnit2Cost.AddRange(new float[] { 30, 240, 20000, 200000, 750000 });
        eachUnit3Cost.AddRange(new float[] { 100, 800, 70000, 700000, 1000000 });

        eachAgeEvolveXPCost.AddRange(new float[] { 1200, 20000, 300000, 2000000, 1000000000 });

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
