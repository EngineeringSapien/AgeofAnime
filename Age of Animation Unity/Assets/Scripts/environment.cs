using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class environment : MonoBehaviour {

    public GameObject p1BaseLocation;
    public GameObject p2BaseLocation;
    public Age age;

    GameObject P1Base;
    GameObject P2Base;

    public GameObject background;
    public GameObject sky;

    Vector2 baseOffset = new Vector2(-5, 0);

    private List<string> skyList = new List<string>();
    private List<string> baseList = new List<string>();


    private void Awake()
    {
        skyList.Add("sky0");
        skyList.Add("narutoBackground");
        skyList.Add("dbzBackground");
        skyList.Add("sky1");
        skyList.Add("sky0");
        skyList.Add("sky1");
        skyList.Add("sky0");
       

        baseList.AddRange(new string[] { "base0", "base1", "base0", "base1", "base0", "base1" });
    }

    void Start () {
        P1Base = Instantiate (Resources.Load(baseList[0]) as GameObject, p1BaseLocation.transform.position, Quaternion.identity);
        P2Base = Instantiate (Resources.Load(baseList[0]) as GameObject, p2BaseLocation.transform.position, Quaternion.identity);

        P1Base.gameObject.layer = 12;
        P2Base.gameObject.layer = 13;

        ChangeBackground(age.globalAge);    

    }


    public void ChangeBases(string player, int age)
    {

        if (player == "P1")
        {
            Object.Destroy(this.P1Base);
            GameObject P1Base = Instantiate(Resources.Load(baseList[age]) as GameObject, p1BaseLocation.transform.position , Quaternion.identity);
            P1Base.gameObject.layer = 12;
        }
        if (player == "P2")
        {
            Object.Destroy(this.P2Base);
            GameObject P2Base = Instantiate(Resources.Load(baseList[age]) as GameObject, p2BaseLocation.transform.position, Quaternion.identity);
            P2Base.gameObject.layer = 13;
        }
    }


    public void ChangeBackground(int age)
    {
        Destroy(GameObject.FindWithTag("sky"));
        GameObject sky = Instantiate(Resources.Load(skyList[age]) as GameObject, background.transform.position, Quaternion.identity);
    }
}
