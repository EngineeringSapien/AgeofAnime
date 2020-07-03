using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class health : MonoBehaviour {

    
    public float unitsStartingHealth;
    public float unitsCurrentHealth;

    public float deathwait = .25f;
    public GameObject thisUnitsDeathSprite;

    score Score;
    Attack attack;
    spawn Spawn;
    Units units;
    characterSpawner Spawner;

    string nameEdit1 = "(Clone)";
    string nameEdit2 = " (UnityEngine.GameObject)";

    string Character1 = "Character1";
    string Character2 = "Character2";
    string Character3 = "Character3";
    string Character4 = "Character4";


    private void Awake()
    {
        Score = FindObjectOfType<score>();
        attack = gameObject.GetComponentInChildren<Attack>();
        Spawn = FindObjectOfType<spawn>();        
        units = FindObjectOfType<Units>();
        Spawner = FindObjectOfType<characterSpawner>();
    }


    void Start()
    {


        if (this.gameObject.tag == "Player1")
        {
            if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P1character1.ToString())
            { this.gameObject.name = Character1; }

            if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P1character2.ToString())
            { this.gameObject.name = Character2; }

            if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P1character3.ToString())
            { this.gameObject.name = Character3; }
        }

        if (this.gameObject.tag == "Player2")
        {
            if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P2character1.ToString())
            { this.gameObject.name = Character1; }

            if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P2character2.ToString())
            { this.gameObject.name = Character2; }

            if (this.gameObject.name.Replace(nameEdit1, nameEdit2) == units.P2character3.ToString())
            { this.gameObject.name = Character3; }
        }
    }


    void StartHealth()
    {
        unitsCurrentHealth = unitsStartingHealth;

    }


    public void TakeDamage(int damage)
    {        
        unitsCurrentHealth -= damage;
	
	    if (unitsCurrentHealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        Score.ChangeTreasury("increase", this.gameObject.name, this.gameObject.tag);
        Score.ChangeExperience("increase", this.gameObject.name, this.gameObject.tag);

        var clone = Instantiate(thisUnitsDeathSprite, transform.position, Quaternion.identity);

        Destroy(gameObject);
        Destroy(clone, deathwait);

        if (clone.name == "Character1") { Spawner.inGameUnit1Bots.Remove(this.gameObject.name); }
        else if (clone.name == "Character2") { Spawner.inGameUnit2Bots.Remove(this.gameObject.name); }
        else if (clone.name == "Character3") { Spawner.inGameUnit3Bots.Remove(this.gameObject.name); }

    }
    

}
