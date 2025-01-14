﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class Attack : MonoBehaviour {

    public Animator thisUnitsAnimator;
    public PlayerMovement thisUnitsMovementLogic;

    int enemyLayer;
    int enemyBaseLayer;
    public int myAge;

    public float currentMeleeDamage;
    public float currentRangeDamage;

    string parentTag;
    string enemyTag;


    private void Awake()
    {
        parentTag = this.transform.parent.tag;
        
        #region Assigning Layers For Hit Box
        if (parentTag == "Player1")
        {
            enemyLayer = 13;
            enemyBaseLayer = 17;
        }
        if (parentTag == "Player2")
        {
            enemyLayer = 12;
            enemyBaseLayer = 16;
        }
        #endregion
    }


    private void Update()
    {
        if (thisUnitsMovementLogic.canMeleeAttack == true)
        { MeleeAttack(); }

        else if (thisUnitsMovementLogic.canRangeAttack == true)
        { RangeAttack(); }
    }


    void MeleeAttack()
    {
        thisUnitsAnimator.SetBool("isFiring", false);
        thisUnitsAnimator.SetBool("isAttacking", true);
    }


    void RangeAttack()
    {
        thisUnitsAnimator.SetBool("isAttacking", false);
        thisUnitsAnimator.SetBool("isFiring", true);
    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.layer == enemyLayer)
        {
            if (this.thisUnitsAnimator.GetCurrentAnimatorStateInfo(0).IsName("ItachiFire"))
            {
                health Health = hitInfo.GetComponent<health>();
                if (Health != null)
                { Health.TakeDamage(currentRangeDamage); }
            }

            else if (this.thisUnitsAnimator.GetCurrentAnimatorStateInfo(0).IsName("ItachiAttack"))
            {
                health Health = hitInfo.GetComponent<health>();
                if (Health != null)
                { Health.TakeDamage(currentMeleeDamage); }
            }

            else
            {
                health Health = hitInfo.GetComponent<health>();
                if (Health != null)
                { Health.TakeDamage(currentMeleeDamage); }
            }
        }

        if (hitInfo.gameObject.layer == enemyBaseLayer)
        {       
            baseHealth basehealth = hitInfo.GetComponent<baseHealth>();
            if (basehealth != null)
            { basehealth.TakeBaseDamage(currentMeleeDamage); }
        }
    }

}
