using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour {

    public spawn button;

    public GameObject P1character1;
    public GameObject P1character2;
    public GameObject P1character3;

    public GameObject P2character1;
    public GameObject P2character2;
    public GameObject P2character3;

    public List<string> unit1List = new List<string>();
    public List<string> unit2List = new List<string>();
    public List<string> unit3List = new List<string>();

    public List<int> unit1DamageList = new List<int>();
    public List<int> unit2DamageList = new List<int>();
    public List<int> unit3DamageList = new List<int>();

    public List<int> unit2RangeDamageList = new List<int>();
    public List<int> unit3RangeDamageList = new List<int>();

    public List<float> unit1SpawntimeList = new List<float>();
    public List<float> unit2SpawntimeList = new List<float>();
    public List<float> unit3SpawntimeList = new List<float>();

    public List<float> unit1HealthList = new List<float>();
    public List<float> unit2HealthList = new List<float>();
    public List<float> unit3HealthList = new List<float>();

    public List<float> unit1SpeedList = new List<float>();
    public List<float> unit2SpeedList = new List<float>();
    public List<float> unit3SpeedList = new List<float>();

    public List<float> unit1RangeList = new List<float>();
    public List<float> unit2RangeList = new List<float>();
    public List<float> unit3RangeList = new List<float>();



    private void Awake()
    {
        unit1List.AddRange(new string[] {"Kakashi", "4th Hokage", "Vegeta", "Rukia", "Eric FullMetal" });
        unit2List.AddRange(new string[] {"Itachi", "Pain", "Goku", "Ichigo", "Colonel Mustang" });
        unit3List.AddRange(new string[] {"Zabuza", "Sage Mode Naruto", "Frieza", "Byakuya", "Fuhrer Bradley" });

        unit1DamageList.AddRange(new int[] { 15, 35, 35, 60, 90 });             
        unit2DamageList.AddRange(new int[] { 8, 15, 35, 40, 70 });             
        unit3DamageList.AddRange(new int[] { 48, 50, 60, 110, 90 });

        unit2RangeDamageList.AddRange(new int[] { 20, 30, 50, 60, 150 });             
        unit3RangeDamageList.AddRange(new int[] { 12, 80, 80, 120, 90 });

        unit1SpawntimeList.AddRange(new float[] { 1f, 1.5f, 2f, 2.5f, 3f});
        unit2SpawntimeList.AddRange(new float[] { 1.2f, 1.7f, 2.3f, 2.8f, 3.2f});
        unit3SpawntimeList.AddRange(new float[] { 3f, 3.33f, 3.66f, 4f, 5f });

        unit1HealthList.AddRange(new float[] { 100f, 80f, 115f, 180f, 240f });       
        unit2HealthList.AddRange(new float[] { 80f, 100f, 130f, 200f, 240f });      
        unit3HealthList.AddRange(new float[] { 100f, 150f, 180f, 350f, 700f });

        /*unit1SpeedList.AddRange(new float[] { 5f, 5f, 5, 5f, 5f });
        unit2SpeedList.AddRange(new float[] { 5, 5, 5, 5f, 5f });
        unit3SpeedList.AddRange(new float[] { 5, 5f, 5, 5f, 5f });
        */ 

        unit1SpeedList.AddRange(new float[] { 1f, 3f, 2, 1f, 1f });
        unit2SpeedList.AddRange(new float[] { 1, 1, 2, 1.5f, 1f });
        unit3SpeedList.AddRange(new float[] { 1, 1.3f, 2, 1f, 2f });
        
        unit1RangeList.AddRange(new float[] { 1, 1, 1, 1, 1 });
        unit2RangeList.AddRange(new float[] { 17, 18, 20, 20, 20 });
        unit3RangeList.AddRange(new float[] { 17, 18, 20, 20, 20 });

        P1character1 = (Resources.Load(unit1List[0]) as GameObject);
        P1character2 = (Resources.Load(unit2List[0]) as GameObject);
        P1character3 = (Resources.Load(unit3List[0]) as GameObject);

        P2character1 = (Resources.Load(unit1List[0]) as GameObject);
        P2character2 = (Resources.Load(unit2List[0]) as GameObject);
        P2character3 = (Resources.Load(unit3List[0]) as GameObject);

    }


    public void ChangeUnits(string player, int age)
    {
        if (player == "P1")
        {
            P1character1 = (Resources.Load(unit1List[age]) as GameObject);
            P1character2 = (Resources.Load(unit2List[age]) as GameObject);
            P1character3 = (Resources.Load(unit3List[age]) as GameObject);
        }

        else if (player == "P2")
        {
            P2character1 = (Resources.Load(unit1List[age]) as GameObject);
            P2character2 = (Resources.Load(unit2List[age]) as GameObject);
            P2character3 = (Resources.Load(unit3List[age]) as GameObject);
        }
    }



}
