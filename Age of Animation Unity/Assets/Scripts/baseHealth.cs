using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseHealth : MonoBehaviour {

    public float currentHealth;
    public float maxHealth;
    private string playerNumberText;

    public Age age;
    public GameManager gameManager;
    HealthBar TeamHealthBar;

    private List<int> baseHealthByAge = new List<int>();


    private void Awake()
    {
        baseHealthByAge.AddRange(new int[] { 500, 750, 1125, 1688, 2531, 3797 });
    }


    private void Start()
    {
        TeamHealthBar = gameObject.GetComponentInChildren<HealthBar>();

        maxHealth = baseHealthByAge[0];
        currentHealth = maxHealth;

        playerNumberText = gameObject.name.Substring(1, 1);
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


    public void TakeBaseDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            gameManager.GameOver(playerNumberText);
        }

        TeamHealthBar.UpdateTeamHealthBar();
    }

}
