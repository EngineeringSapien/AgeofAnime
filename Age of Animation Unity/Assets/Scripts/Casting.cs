using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour {

    public float unitRange;
    public float friendlyRange;

    int enemyLayer;
    int friendlyLayer;

    int enemyMask;
    int friendlyMask;

    Vector2 unitForwardDirection;
    private float rayOffset = .30f;
    private int offSetDirection;

    PlayerMovement movement;
    UnitType unit;

    private void Awake()
    {
        unit = gameObject.GetComponent<UnitType>();

        #region Assigning Layers
        if (this.gameObject.tag == "Player1")
        {
            enemyLayer = 13;
            friendlyLayer = 12;
        }
        if (this.gameObject.tag == "Player2")
        {
            enemyLayer = 12;
            friendlyLayer = 13;
        }   
        #endregion

    }


    void Start ()
    {
        movement = gameObject.GetComponent<PlayerMovement>();

        enemyMask = (1 << enemyLayer);
        friendlyMask = (1 << friendlyLayer);


        #region Determing Ray Direction
        if (this.gameObject.tag == "Player1")
        {
            unitForwardDirection = Vector2.right;
            offSetDirection = 1;
        }
        else if (this.gameObject.tag == "Player2")
        {
            unitForwardDirection = Vector2.left;
            offSetDirection = -1;
        }
        #endregion

    }


    void Update ()
    {
        Vector2 startingposition = new Vector2((rayOffset * offSetDirection) + transform.position.x, transform.position.y);
        Debug.DrawRay(startingposition, unitForwardDirection, Color.red);


        if (unit.unitType == "melee")
        {
            RaycastHit2D hitEnemy = Physics2D.Raycast(startingposition, unitForwardDirection, unitRange / 2, enemyMask);
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
            RaycastHit2D hitEnemyClose = Physics2D.Raycast(startingposition, unitForwardDirection, unitRange / 50, enemyMask);
            RaycastHit2D hitFriendly = Physics2D.Raycast(startingposition, unitForwardDirection, friendlyRange / 20, friendlyMask);

            if (hitEnemyClose)
            {
                movement.AttackTrue();
            }

            else if (hitFriendly)
            {
                RaycastHit2D hitEnemyFar = Physics2D.Raycast(startingposition, unitForwardDirection, unitRange / 10, enemyMask);

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
            RaycastHit2D hitEnemyClose = Physics2D.Raycast(startingposition, unitForwardDirection, unitRange / 50, enemyMask);
            RaycastHit2D hitFriendly = Physics2D.Raycast(startingposition, unitForwardDirection, friendlyRange / 20, friendlyMask);

            if (hitEnemyClose)
            {
                movement.AttackTrue();
            }

            else if (hitFriendly)
            {
                RaycastHit2D hitEnemyFar = Physics2D.Raycast(startingposition, unitForwardDirection, unitRange / 10, enemyMask);

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
	
}
