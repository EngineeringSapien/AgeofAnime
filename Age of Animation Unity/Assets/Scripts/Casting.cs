using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Casting : MonoBehaviour {

    public float rangeRayDistance;
    public float meleeRayDistance;
    public float friendlyRange;

    int enemyLayer;
    int friendlyLayer;
    int friendlyBaseLayer;

    int enemyMask;
    int friendlyMask;
    int friendlyBaseMask;
    int enemyBaseLayer;

    Vector2 unitForwardDirection;
    private float rayOffset; // = .30f;
    private float rayOffsetFactor = 7.5f;
    private int offSetDirection;

    PlayerMovement movement;
    UnitConstructor unit;
    baseHealth theBase;

    private void Awake()
    {
        unit = gameObject.GetComponent<UnitConstructor>();
        theBase = gameObject.GetComponentInParent<baseHealth>();

        #region Assigning Layers
        if (this.gameObject.tag == "Player1" || this.gameObject.name == "P1 Base")
        {
            enemyLayer = 13;
            friendlyLayer = 12;
            friendlyBaseLayer = 16;
            enemyBaseLayer = 17;
        }
        if (this.gameObject.tag == "Player2" || this.gameObject.name == "P2 Base")
        {
            enemyLayer = 12;
            friendlyLayer = 13;
            friendlyBaseLayer = 17;
            enemyBaseLayer = 16;
        }   
        #endregion

    }


    void Start ()
    {
        movement = gameObject.GetComponent<PlayerMovement>();

        enemyMask = (1 << enemyLayer) | (1 << enemyBaseLayer);
        friendlyMask = (1 << friendlyLayer);
    
        #region Determing Ray Direction
        if (this.gameObject.tag == "Player1" || this.gameObject.name == "P1 Base")
        {
            unitForwardDirection = Vector2.right;
            offSetDirection = 1;
        }
        else if (this.gameObject.tag == "Player2" || this.gameObject.name == "P2 Base")
        {
            unitForwardDirection = Vector2.left;
            offSetDirection = -1;
        }
        #endregion

        rayOffset = (gameObject.transform.localScale.x * gameObject.transform.localScale.y) / rayOffsetFactor;

    }


    void Update ()
    {
        if (gameObject.tag != "base")
        {
            Vector2 startingposition = new Vector2((rayOffset * offSetDirection) + transform.position.x, transform.position.y);
            Debug.DrawRay(startingposition, unitForwardDirection, Color.red);


            if (unit.unitType == "melee")
            {
                RaycastHit2D hitEnemy = Physics2D.Raycast(startingposition, unitForwardDirection, meleeRayDistance, enemyMask);
                RaycastHit2D hitFriendly = Physics2D.Raycast(startingposition, unitForwardDirection, friendlyRange / 20, friendlyMask);

                if (hitEnemy)
                {
                    movement.AttackTrue();
                }

                else if (hitFriendly)
                {
                    if (hitFriendly.transform.tag == "base") { movement.WalkTrue(); }

                    // else if the friendly is a unit, just idle behind them
                    else { movement.IdleTrue(); }
                }

                //Just in case, to ensure no one gets stuck not moving
                else
                {
                    movement.WalkTrue();
                }
            }


            else if (unit.unitType == "ranged")
            {
                RaycastHit2D hitEnemyClose = Physics2D.Raycast(startingposition, unitForwardDirection, meleeRayDistance, enemyMask);
                RaycastHit2D hitFriendly = Physics2D.Raycast(startingposition, unitForwardDirection, friendlyRange / 20, friendlyMask);

                if (hitEnemyClose)
                {
                    movement.AttackTrue();
                }

                else if (hitFriendly)
                {
                    RaycastHit2D hitEnemyFar = Physics2D.Raycast(startingposition, unitForwardDirection, rangeRayDistance / 10, enemyMask);

                    if (hitEnemyFar) { movement.FireTrue(); }

                    else { movement.IdleTrue(); }

                    if (hitFriendly.transform.tag == "base") { movement.WalkTrue(); }
                }

                else
                {
                    movement.WalkTrue();
                }
            }


            else if (unit.unitType == "power")
            {
                RaycastHit2D hitEnemyClose = Physics2D.Raycast(startingposition, unitForwardDirection, meleeRayDistance, enemyMask);
                RaycastHit2D hitFriendly = Physics2D.Raycast(startingposition, unitForwardDirection, friendlyRange / 20, friendlyMask);

                if (hitEnemyClose)
                {
                    movement.AttackTrue();
                }

                else if (hitFriendly)
                {
                    RaycastHit2D hitEnemyFar = Physics2D.Raycast(startingposition, unitForwardDirection, rangeRayDistance / 10, enemyMask);

                    if (hitEnemyFar) { movement.FireTrue(); }

                    else { movement.IdleTrue(); }

                    if (hitFriendly.transform.tag == "base") { movement.WalkTrue(); }
                }

                else
                {
                    movement.WalkTrue();
                }
            }
        }

        //else
        //{
        //    Vector2 startingposition = new Vector2((rayOffset * offSetDirection) + transform.position.x, transform.position.y - .5f);
        //    Debug.DrawRay(startingposition, unitForwardDirection * theBase.checkGuardDistance, Color.red);

        //    RaycastHit2D hitGuard = Physics2D.Raycast(startingposition, unitForwardDirection, theBase.checkGuardDistance, friendlyMask);
        //    Debug.Log("shoot ray");

        //    if (hitGuard)
        //    {
        //        Debug.Log("hit guard");
        //        theBase.isGuarded = true;
        //    }

        //    else
        //    {
        //        Debug.Log("no guard");
        //        theBase.isGuarded = false;
        //    }
        //}

    }


    public void CheckforGuard()
    {
        Vector2 startingposition = new Vector2((rayOffset * offSetDirection) + transform.position.x, transform.position.y - .5f);
        Debug.DrawRay(startingposition, unitForwardDirection * theBase.checkGuardDistance, Color.red);

        RaycastHit2D hitGuard = Physics2D.Raycast(startingposition, unitForwardDirection, theBase.checkGuardDistance, friendlyMask);

        if (hitGuard)
        {
            theBase.isGuarded = true;
        }

        else
        {
            theBase.isGuarded = false;
        }
    }

}
