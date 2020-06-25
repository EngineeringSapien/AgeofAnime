using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStats : MonoBehaviour {

    // since these are children of the object this script sits on, I don't think I need a public reference
    // I think this method will make it so I can just copy the script to other buttons without any trouble
    public Text UnitName;
    public Text UnitCost;
    public Text UnitDamage;
    public Text UnitSpawn;
    public Text UnitHealth;

    public Units units; //to get the unitName, damage, spawntime, and health
    public score Score; //to get the UnitCost

    public Age age;

    string buttonName;

    private void Start()
    {
        buttonName = transform.parent.gameObject.name;
  
    }


    void Update ()
    {
        // Name //
        TextName();

        //  Cost  //
        TextCost();

        // Damage //
        TextDamage(buttonName, age.P1Age, age.P2Age);

        // SpawnTime //
        TextSpawnTime(buttonName, age.P1Age, age.P2Age);

        // Health //
        TextHealth(buttonName, age.P1Age, age.P2Age);

    }


    private void TextDamage(string button, int age1, int age2)
    {
        //Debug.Log(button);
        //Player 1
        if (button == "P1Button1")
        {
            UnitDamage.text = "Damage: " + units.unit1DamageList[age1] + " hp";
        }
        else if (button == "P1Button2")
        {
            UnitDamage.text = "Damage: " + units.unit2DamageList[age1] + " hp";
        }
        else if (button == "P1Button3")
        {
            UnitDamage.text = "Damage: " + units.unit3DamageList[age1] + " hp";
        }

        //P2
        if (button == "P2Button1")
        {
            UnitDamage.text = "Damage: " + units.unit1DamageList[age2] + " hp";
        }
        else if (button == "P2Button2")
        {
            UnitDamage.text = "Damage: " + units.unit2DamageList[age2] + " hp";
        }
        else if (button == "P2Button3")
        {
            UnitDamage.text = "Damage: " + units.unit3DamageList[age2] + " hp";
        }

    }



    private void TextSpawnTime(string button, int age1, int age2)
    {
        //P 1
        if (button == "P1Button1")
        {
            UnitSpawn.text = "Spawn Time: " + units.unit1SpawntimeList[age1] + " s";
        }
        else if (button == "P1Button2")
        {
            UnitSpawn.text = "Spawn Time: " + units.unit2SpawntimeList[age1] + " s";
        }
        else if (button == "P1Button3")
        {
            UnitSpawn.text = "Spawn Time: " + units.unit3SpawntimeList[age1] + " s";
        }


        //P 2
        if (button == "P2Button1")
        {
            UnitSpawn.text = "Spawn Time: " + units.unit1SpawntimeList[age2] + " s";
        }
        else if (button == "P2Button2")
        {
            UnitSpawn.text = "Spawn Time: " + units.unit2SpawntimeList[age2] + " s";
        }
        else if (button == "P2Button3")
        {
            UnitSpawn.text = "Spawn Time: " + units.unit3SpawntimeList[age2] + " s";
        }

    }



    private void TextHealth(string button, int age1, int age2)
    {
        //P 1
        if (button == "P1Button1")
        {
            UnitHealth.text = "Health: " + units.unit1HealthList[age1] + " hp";
        }
        else if (button == "P1Button2")
        {
            UnitHealth.text = "Health: " + units.unit2HealthList[age1] + " hp";
        }
        else if (button == "P1Button3")
        {
            UnitHealth.text = "Health: " + units.unit3HealthList[age1] + " hp";
        }

        //P 2
        if (button == "P2Button1")
        {
            UnitHealth.text = "Health: " + units.unit1HealthList[age2] + " hp";
        }
        else if (button == "P2Button2")
        {
            UnitHealth.text = "Health: " + units.unit2HealthList[age2] + " hp";
        }
        else if (button == "P2Button3")
        {
            UnitHealth.text = "Health: " + units.unit3HealthList[age2] + " hp";
        }

    }


    private void TextName()
    {
        //P1
        if (transform.parent.gameObject.name == "P1Button1")
        {
            UnitName.text = "Unit: " + units.P1character1.gameObject.name;		
        }
        else if (transform.parent.gameObject.name == "P1Button2")
        {
            UnitName.text = "Unit: " + units.P1character2.gameObject.name;		
        }
        else if (transform.parent.gameObject.name == "P1Button3")
        {
            UnitName.text = "Unit: " + units.P1character3.gameObject.name;		
        }

        //P2
        else if (transform.parent.gameObject.name == "P2Button1")
        {
            UnitName.text = "Unit: " + units.P2character1.gameObject.name;		
        }
        else if (transform.parent.gameObject.name == "P2Button2")
        {
            UnitName.text = "Unit: " + units.P2character2.gameObject.name;		
        }
        else if (transform.parent.gameObject.name == "P2Button3")
        {
            UnitName.text = "Unit: " + units.P2character3.gameObject.name;		
        }
    }


    private void TextCost()
    {
        //P1
        if (transform.parent.gameObject.name == "P1Button1")
        {
            UnitCost.text = "Cost: " + Score.p1Unit1cost + " gold";
        }
        else if (transform.parent.gameObject.name == "P1Button2")
        {
            UnitCost.text = "Cost: " + Score.p1Unit2cost + " gold";
        }
        else if (transform.parent.gameObject.name == "P1Button3")
        {
            UnitCost.text = "Cost: " + Score.p1Unit3cost + " gold";
        }

        //P2
        else if (transform.parent.gameObject.name == "P2Button1")
        {
            UnitCost.text = "Cost: " + Score.p2Unit1cost + " gold";
        }
        else if (transform.parent.gameObject.name == "P2Button2")
        {
            UnitCost.text = "Cost: " + Score.p2Unit2cost + " gold";
        }
        else if (transform.parent.gameObject.name == "P2Button3")
        {
            UnitCost.text = "Cost: " + Score.p2Unit3cost + " gold";
        }
    }
}
