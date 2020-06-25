using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class Attack : MonoBehaviour {

 
    public Animator animator;
    public PlayerMovement thisCharactersMovementLogic;
    private Units units;
    private Age age;

    int enemyLayer;
    public int myAge;

    public int currentMeleeDamage;


    public int currentRangeDamage;

    string parentTag;
    string enemyTag;


    private void Awake()
    {
        parentTag = this.transform.parent.tag;
        units = GameObject.Find("UnitManager").GetComponent<Units>();
        
        #region Assigning Layers For Hit Box
        if (parentTag == "Player1")
        {
            enemyLayer = 13;
        }
        if (parentTag == "Player2")
        {
            enemyLayer = 12;
        }
        #endregion
    }


    private void Update()
    {
        if (thisCharactersMovementLogic.canAttack == true)
        {
            playerAttack();
        }

        else if (thisCharactersMovementLogic.canFire == true)
        {
            
            FireAttack();
        }
    }

    void playerAttack()
    {
        animator.SetBool("isFiring", false);
        animator.SetBool("isAttacking", true);

    }


    void FireAttack()
    {
        animator.SetBool("isAttacking", false);
        animator.SetBool("isFiring", true);

    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.layer == enemyLayer)
        {
            if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("ItachiFire"))
            {

                health Health = hitInfo.GetComponent<health>();
                if (Health != null)
                {
                    Health.TakeDamage(currentRangeDamage);
                }
            }
            else if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("ItachiAttack"))
            {
                health Health = hitInfo.GetComponent<health>();
                if (Health != null)
                {
                    Health.TakeDamage(currentMeleeDamage);
                }
            }
            else
            {
                health Health = hitInfo.GetComponent<health>();
                if (Health != null)
                {
                    Health.TakeDamage(currentMeleeDamage);
                }
            }


            baseHealth basehealth = hitInfo.GetComponent<baseHealth>();
            if (basehealth != null)
            {
                basehealth.BaseDamage(currentMeleeDamage);
            }
        }
    }

}
