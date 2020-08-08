using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UnitConstructor : MonoBehaviour {


    private Age age;
    private int myAge;
    public string unitType;

    private Attack attack;
    private health Health;
    private PlayerMovement pm;
    private Casting cast;
    private Units units;

    string nameEdit1 = "(Clone)";
    string nameEdit2 = " (UnityEngine.GameObject)";

    string Character1 = "Character1";
    string Character2 = "Character2";
    string Character3 = "Character3";


    void Start ()
    {
        age = GameObject.Find("AgeManager").GetComponent<Age>();
        units = GameObject.Find("UnitManager").GetComponent<Units>();
        attack = gameObject.GetComponentInChildren<Attack>();
        Health = gameObject.GetComponent<health>();
        pm = gameObject.GetComponent<PlayerMovement>();
        cast = gameObject.GetComponent<Casting>();


        if (this.gameObject.tag == "Player1")
        {
            myAge = age.P1Age;
            SetupP1UnitNames();
        }
        
        else if (this.gameObject.tag == "Player2")
        {
            myAge = age.P2Age;
            SetupP2UnitNames();
        }


        if (this.gameObject.name == "Character1") { SetupUnit1(); }

        else if (this.gameObject.name == "Character2") { SetupUnit2(); }

        else if (this.gameObject.name == "Character3") { SetupUnit3(); }
    }


    private void SetupP1UnitNames()
    {
        if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P1character1.ToString())
        { this.gameObject.name = Character1; }

        if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P1character2.ToString())
        { this.gameObject.name = Character2; }

        if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P1character3.ToString())
        { this.gameObject.name = Character3; }
    }


    private void SetupP2UnitNames()
    {
        if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P2character1.ToString())
        { this.gameObject.name = Character1; }

        if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P2character2.ToString())
        { this.gameObject.name = Character2; }

        if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P2character3.ToString())
        { this.gameObject.name = Character3; }
    }


    private void SetupUnit1()
    {
        SetUnitType("melee");
        SetMeleeDamage(units.eachUnit1Damage[myAge]);
        SetUnitHealth(units.eachUnit1Health[myAge]);
        SetUnitSpeed(units.eachUnit1Speed[myAge]);
        SetUnitMeleeDistance(units.eachUnit1MeleeDistance[myAge]);
    }


    private void SetupUnit2()
    {
        unitType = "ranged";
        SetMeleeDamage(units.eachUnit2Damage[myAge]);
        SetRangeDamage(units.eachUnit2RangeDamage[myAge]);
        SetUnitHealth(units.eachUnit2Health[myAge]);
        SetUnitSpeed(units.eachUnit2Speed[myAge]);
        SetUnitMeleeDistance(units.eachUnit2MeleeDistance[myAge]);
        SetUnitRangeDistance(units.eachUnit2RangeDistance[myAge]);
    }


    private void SetupUnit3()
    {
        unitType = "power";
        SetMeleeDamage(units.eachUnit3Damage[myAge]);
        SetRangeDamage(units.eachUnit3RangeDamage[myAge]);
        SetUnitHealth(units.eachUnit3Health[myAge]);
        SetUnitSpeed(units.eachUnit3Speed[myAge]);
        SetUnitMeleeDistance(units.eachUnit3MeleeDistance[myAge]);
        SetUnitRangeDistance(units.eachUnit3RangeDistance[myAge]);
    }


    private void SetUnitType(string type)
    {
        unitType = type;
    }


    private void SetMeleeDamage(float meleeDamage)
    {
        attack.currentMeleeDamage = meleeDamage;
    }


    private void SetRangeDamage(float rangeDamage)
    {
        attack.currentRangeDamage = rangeDamage;
    }


    private void SetUnitHealth(float unitHealth)
    {
        Health.unitsStartingHealth = unitHealth;
        Health.unitsCurrentHealth = Health.unitsStartingHealth;
    }


    private void SetUnitSpeed(float unitSpeed)
    {
        pm.speed = unitSpeed;
    }


    private void SetUnitMeleeDistance(float meleeDistance)
    {
        cast.meleeRayDistance = meleeDistance;
    }


    private void SetUnitRangeDistance(float rangeDistance)
    {
        cast.rangeRayDistance = rangeDistance;
    }

}
