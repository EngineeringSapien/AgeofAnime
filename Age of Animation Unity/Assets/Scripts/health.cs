using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class health : MonoBehaviour {
    
    public float unitsStartingHealth;
    public float unitsCurrentHealth;

    private float deathwait = .50f;
    public GameObject thisUnitsDeathSprite;

    score Score;
    characterSpawner Spawner;
    HealthBar HpBar;
    UnitConstructor unitConstructor;


    void Start()
    {
        HpBar = gameObject.GetComponentInChildren<HealthBar>();
        Score = FindObjectOfType<score>();
        Spawner = FindObjectOfType<characterSpawner>();
        unitConstructor = FindObjectOfType<UnitConstructor>();
    }


    public void TakeDamage(float damage)
    {        
        unitsCurrentHealth -= damage;

        if (unitsCurrentHealth <= 0) { Die(); }

        else { HpBar.UpdateUnitsHealthBar(); }
    }


    void Die()
    {
        Score.ChangeTreasury("increase", this.gameObject.name, this.gameObject.tag, unitConstructor.unitCost);
        Score.ChangeExperience("increase", this.gameObject.name, this.gameObject.tag, unitConstructor.unitCost);

        var clone = Instantiate(thisUnitsDeathSprite, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(clone, deathwait);

        if (gameObject.tag == "Player2")
        { Spawner.RemoveUnitNames(gameObject.name); }
    }

}
