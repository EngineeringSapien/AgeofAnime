using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UnitType : MonoBehaviour {


    private Age age;
    private int myAge;
    public string unitType;


    private Attack attack;
    private health Health;
    private PlayerMovement pm;
    private Casting cast;
    private Units units;



    private void Awake()
    {
        age = GameObject.Find("AgeManager").GetComponent<Age>();
        attack = gameObject.GetComponentInChildren<Attack>();
        Health = gameObject.GetComponent<health>();
        pm = gameObject.GetComponent<PlayerMovement>();
        cast = gameObject.GetComponent<Casting>();
        units = GameObject.Find("UnitManager").GetComponent<Units>();


        #region Assigning Age For Unit
        if (this.gameObject.tag == "Player1")
        {
            myAge = age.P1Age;
        }
        if (this.gameObject.tag == "Player2")
        {
            myAge = age.P2Age;
        }
        #endregion
    }



    void Start ()
    {

        if (this.gameObject.name == "Character1")
        {
            unitType = "melee";
            attack.currentMeleeDamage = units.unit1DamageList[myAge];
            Health.unitsCurrentHealth = units.unit1HealthList[myAge];
            Health.unitsStartingHealth = units.unit1HealthList[myAge];
            pm.speed = units.unit1SpeedList[myAge];
            cast.unitRange = units.unit1RangeList[myAge];
            
        }

        if (this.gameObject.name == "Character2")
        {
            unitType = "ranged";
            attack.currentMeleeDamage = units.unit2DamageList[myAge];
            attack.currentRangeDamage = units.unit2RangeDamageList[myAge];
            Health.unitsCurrentHealth = units.unit2HealthList[myAge];
            Health.unitsStartingHealth = units.unit2HealthList[myAge];
            pm.speed = units.unit2SpeedList[myAge];
            cast.unitRange = units.unit2RangeList[myAge];
        }

        if (this.gameObject.name == "Character3")
        {
            unitType = "power";
            attack.currentMeleeDamage = units.unit3DamageList[myAge];
            attack.currentRangeDamage = units.unit3RangeDamageList[myAge];
            Health.unitsCurrentHealth = units.unit3HealthList[myAge];
            Health.unitsStartingHealth = units.unit3HealthList[myAge];
            pm.speed = units.unit3SpeedList[myAge];
            cast.unitRange = units.unit3RangeList[myAge];
        }
    }

}
