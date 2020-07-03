using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseHealth : MonoBehaviour {

    public int currentHealth;
    public int maxHealth;

    public Age age;
    //HealthBar HpBar;

    private List<int> baseHealthByAge = new List<int>();



    private void Awake()
    {
        baseHealthByAge.AddRange(new int[] { 500, 750, 1125, 1688, 2531, 3797 });
    }


    private void Start()
    {
        maxHealth = baseHealthByAge[0];
        currentHealth = maxHealth;
    }


    public void ResetHealth(int player)
    {
        currentHealth = Mathf.RoundToInt((float)currentHealth * 1.5f);

        if (player == 1)
        {
            maxHealth = baseHealthByAge[age.P1Age];
        }
        else
        {
            maxHealth = baseHealthByAge[age.P2Age];
        }
    }


    public void TakeBaseDamage(int damage)
    {
        currentHealth -= damage;


    }


}
