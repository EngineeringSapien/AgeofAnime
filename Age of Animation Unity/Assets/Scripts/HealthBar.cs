using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    Transform Bar;

    private float teamHP;
    private float maxHP;
    private float unitHP;
    private float maxunitHP;
       
    baseHealth basehealth;
    health Health;
    
	void Start ()
    {
        Bar = transform.Find("Bar");

        if (transform.parent != null && transform.parent.tag == "base")
        {
            basehealth = transform.parent.GetComponent<baseHealth>();
        }

        else if (transform.parent != null && transform.parent.tag == "Player1" || 
            transform.parent != null && transform.parent.tag == "Player2")
        {
            Health = transform.parent.GetComponent<health>();
        }

    }
	

	void Update ()
    {
        if (transform.parent != null && transform.parent.tag == "base")
        {
            TeamHealthBar();
        }
        else if (transform.parent != null && transform.parent.tag == "Player1" || 
            transform.parent != null && transform.parent.tag == "Player2")
        {
            UnitHealthBar();
        }
    }


    void TeamHealthBar()
    {
        teamHP = basehealth.currentHealth;
        maxHP = basehealth.maxHealth;

        if (teamHP > 0 && teamHP < maxHP)
        {
            Bar.localScale = new Vector3(teamHP / maxHP, 1f);
        }
        else
        {
            //Game Over
        }
    }


    void UnitHealthBar()
    {
        unitHP = Health.unitsCurrentHealth;
        maxunitHP = Health.unitsStartingHealth;
        ChangeBarColor(transform.parent.tag);

        if (unitHP > 0 && unitHP < maxunitHP)
        {
            Bar.localScale = new Vector3(unitHP / maxunitHP, 1f);
        }
        else
        {
            //Unit dead
        }
    }

    void ChangeBarColor(string player)
    {
        if (player == "Player1")
        {
            Bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = Color.cyan;
            //barColor = Color.blue;
        }
        else if (player == "Player2")
        {
            Bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = Color.magenta;
            //barColor = Color.white;
        }
    }




}
