using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {

    //I HAVE THE SAME PROBLEM HERE AS I DO IN THE ATTACK SCRIPT. I HAVE A LIST OF HEALTH VARIABLES FOR EACH UNIT IN UNIT MANAGER
    //BUT THE ACTUAL HEALTH VALUES USED ARE FOUND HERE WHICH ARE PUBLIC FLOATS ON THE UNIT PREFABS. NEED TO LINK THEM.

    public float healthpoints;
    public float currentHealth;
    public float deathwait = .25f;

    public GameObject deathEffect;

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
        currentHealth = healthpoints;

    }


    public void TakeDamage(int damage)
    {        
        currentHealth -= damage;
	
	    if (currentHealth <= 0)
        {
            Die();
        }
    }



    void Die()
    {
        Score.ChangeTreasury("increase", this.gameObject.name, this.gameObject.tag);
        Score.ChangeExperience("increase", this.gameObject.name, this.gameObject.tag);
        var clone = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(clone, deathwait);

        if (clone.name == "Character1") { Spawner.unit1ActiveList.Remove(this.gameObject.name); }
        else if (clone.name == "Character2") { Spawner.unit2ActiveList.Remove(this.gameObject.name); }
        else if (clone.name == "Character3") { Spawner.unit3ActiveList.Remove(this.gameObject.name); }

    }
    

}
