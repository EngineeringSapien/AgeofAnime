using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class environment : MonoBehaviour {

    public GameObject p1BaseLocation;
    public GameObject p2BaseLocation;
    Vector2 baseOffset = new Vector2(-5, 0);
    public GameObject backgroundLocation;

    public Age age;

    private GameObject TheP1Base;
    private GameObject TheP2Base;

    private List<string> allBackgroundSprites = new List<string>();
    private List<string> allBaseSprites = new List<string>();


    private void Awake()
    {
        allBackgroundSprites.AddRange(new string[] { "sky0", "narutoBackground", "dbzBackground", "sky1", "sky0", "sky1", "sky0" } );

        allBaseSprites.AddRange(new string[] { "base0", "base1", "base0", "base1", "base0", "base1" } );
    }

    void Start () {
        TheP1Base = Instantiate (Resources.Load(allBaseSprites[0]) as GameObject, p1BaseLocation.transform.position, Quaternion.identity);
        TheP2Base = Instantiate (Resources.Load(allBaseSprites[0]) as GameObject, p2BaseLocation.transform.position, Quaternion.identity);

        TheP1Base.gameObject.layer = 12;
        TheP2Base.gameObject.layer = 13;

        ChangeBackground(age.globalAge);    

    }


    public void ChangeBases(string player, int age)
    {

        if (player == "P1")
        {
            Object.Destroy(this.TheP1Base);
            GameObject P1Base = Instantiate(Resources.Load(allBaseSprites[age]) as GameObject, p1BaseLocation.transform.position , Quaternion.identity);
            P1Base.gameObject.layer = 12;
        }
        if (player == "P2")
        {
            Object.Destroy(this.TheP2Base);
            GameObject P2Base = Instantiate(Resources.Load(allBaseSprites[age]) as GameObject, p2BaseLocation.transform.position, Quaternion.identity);
            P2Base.gameObject.layer = 13;
        }
    }


    public void ChangeBackground(int age)
    {
        Destroy(GameObject.FindWithTag("Background"));
        GameObject background = Instantiate(Resources.Load(allBackgroundSprites[age]) as GameObject, backgroundLocation.transform.position, Quaternion.identity);
    }
}
