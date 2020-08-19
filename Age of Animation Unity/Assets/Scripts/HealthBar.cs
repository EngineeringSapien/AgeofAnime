using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    Transform Bar;

    private float teamHP;
    private float maxTeamHP;
    private float unitHP;
    private float maxUnitHP;
       
    baseHealth basehealth;
    health Health;

    Color p1Color = Color.cyan;
    Color p2Color = Color.magenta;
    

	void Start ()
    {

        Bar = transform.Find("Bar");

        if (transform.parent != null && transform.parent.tag == "base")
        {
            basehealth = transform.parent.GetComponent<baseHealth>();
            UpdateTeamHealthBar();
        }

        else if (transform.parent != null && transform.parent.tag == "Player1" || transform.parent != null && transform.parent.tag == "Player2")
        {
            Health = transform.parent.GetComponent<health>();
            UpdateUnitsHealthBar();
        }
    }


    public void UpdateTeamHealthBar()
    {
        teamHP = basehealth.currentHealth;
        maxTeamHP = basehealth.maxHealth;

        if (teamHP > 0 && teamHP < maxTeamHP)
        {
            Bar.localScale = new Vector3(teamHP / maxTeamHP, 1f);
        }
    }


    public void UpdateUnitsHealthBar()
    {
        unitHP = Health.unitsCurrentHealth;
        maxUnitHP = Health.unitsStartingHealth;
        ChangeBarColor(transform.parent.tag);

        if (unitHP > 0 && unitHP < maxUnitHP)
        {
            Bar.localScale = new Vector3(unitHP / maxUnitHP, 1f);
        }
    }


    void ChangeBarColor(string player)
    {

        if (player == "Player1")
        {
            Bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = p1Color;
        }
        else if (player == "Player2")
        {
            Bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = p2Color;
        }
    }

}
