using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseHealth : MonoBehaviour {

    public int currentHealth;
    public int maxHealth;

    public Age age;

    private List<int> baseHealthList = new List<int>();



    private void Awake()
    {
        baseHealthList.AddRange(new int[] { 500, 750, 1125, 1688, 2531, 3797 });
    }


    private void Start()
    {
        maxHealth = baseHealthList[0];
        currentHealth = maxHealth;
    }


    public void ResetHealth(int player)
    {
        currentHealth = Mathf.RoundToInt((float)currentHealth * 1.5f);

        if (player == 1)
        {
            maxHealth = baseHealthList[age.P1Age];
        }
        else
        {
            maxHealth = baseHealthList[age.P2Age];
        }
    }


    public void BaseDamage(int damage)
    {
        currentHealth -= damage;
    }


}
