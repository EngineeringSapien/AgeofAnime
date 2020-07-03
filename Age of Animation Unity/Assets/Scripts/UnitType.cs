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

    }



    void Start ()
    {
        age = GameObject.Find("AgeManager").GetComponent<Age>();
        attack = gameObject.GetComponentInChildren<Attack>();
        Health = gameObject.GetComponent<health>();
        pm = gameObject.GetComponent<PlayerMovement>();
        cast = gameObject.GetComponent<Casting>();
        units = GameObject.Find("UnitManager").GetComponent<Units>();


        if (this.gameObject.tag == "Player1") { myAge = age.P1Age; }
        
        if (this.gameObject.tag == "Player2") { myAge = age.P2Age; }


        if (this.gameObject.name == "Character1")
        {
            unitType = "melee";
            attack.currentMeleeDamage = units.eachUnit1Damage[myAge];
            Health.unitsCurrentHealth = units.eachUnit1Health[myAge];
            Health.unitsStartingHealth = units.eachUnit1Health[myAge];
            pm.speed = units.eachUnit1Speed[myAge];
            cast.unitRange = units.eachUnit1Range[myAge];
            
        }

        if (this.gameObject.name == "Character2")
        {
            unitType = "ranged";
            attack.currentMeleeDamage = units.eachUnit2Damage[myAge];
            attack.currentRangeDamage = units.eachUnit2RangeDamage[myAge];
            Health.unitsCurrentHealth = units.eachUnit2Health[myAge];
            Health.unitsStartingHealth = units.eachUnit2Health[myAge];
            pm.speed = units.eachUnit2Speed[myAge];
            cast.unitRange = units.eachUnit2Range[myAge];
        }

        if (this.gameObject.name == "Character3")
        {
            unitType = "power";
            attack.currentMeleeDamage = units.eachUnit3Damage[myAge];
            attack.currentRangeDamage = units.eachUnit3RangeDamage[myAge];
            Health.unitsCurrentHealth = units.eachUnit3Health[myAge];
            Health.unitsStartingHealth = units.eachUnit3Health[myAge];
            pm.speed = units.eachUnit3Speed[myAge];
            cast.unitRange = units.eachUnit3Range[myAge];
        }
    }

}
