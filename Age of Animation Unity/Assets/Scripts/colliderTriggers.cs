using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderTriggers : MonoBehaviour {

   /* public PlayerMovement thisUnitsMovementLogic;
    Collider2D collision;

    public bool triggered = false;

    

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Collision 1");
        //Debug.Log(this.gameObject.name);

        #region HitZone
        if (this.gameObject.name == "Hit Zone")
        {
            Debug.Log("Hit Zone 2");
            triggered = true;
            this.collision = collision;

            if (this.gameObject.tag == "Player1")
            {
                Debug.Log("Player 3");
                if (collision.gameObject.tag == "Player2")
                {
                    Debug.Log("Attack 4");
                    thisUnitsMovementLogic.canWalk = false;
                    thisUnitsMovementLogic.canAttack = true;
                }

                if (collision.gameObject.tag == "P2Base")
                {
                    thisUnitsMovementLogic.canWalk = false;
                    thisUnitsMovementLogic.canAttack = true;
                }
            }

            if (this.gameObject.tag == "Player2")
            {
                if (collision.gameObject.tag == "Player1")
                {
                    thisUnitsMovementLogic.canWalk = false;
                    thisUnitsMovementLogic.canAttack = true;
                }

                if (collision.gameObject.tag == "P1Base")
                {
                    thisUnitsMovementLogic.canWalk = false;
                    thisUnitsMovementLogic.canAttack = true;
                }
            }
        }
        #endregion


        #region FriendZone
        if (this.gameObject.name == "Friend Zone")
        {
            triggered = true;
            this.collision = collision;

            if (this.gameObject.tag == "Player1")
            {
                if (collision.gameObject.tag == "Player1")
                {
                    thisUnitsMovementLogic.canWalk = false;
                    thisUnitsMovementLogic.canIdle = true;
                }
            }

            if (this.gameObject.tag == "Player2")
            {
                if (collision.gameObject.tag == "Player2")
                {
                    thisUnitsMovementLogic.canWalk = false;
                    thisUnitsMovementLogic.canIdle = true;
                }
            }
        }
        #endregion

    }


    void OnTriggerExit2D(Collider2D other)
    {
        #region HitZone
        if (this.gameObject.name == "Hit Zone")
        {
            if (gameObject.gameObject.tag == "Player1")
            {
                if (other.gameObject.tag == "Player2")
                {
                    thisUnitsMovementLogic.canWalk = true;
                    thisUnitsMovementLogic.canAttack = false;
                }
            }
            if (gameObject.gameObject.tag == "Player2")
            {
                if (other.gameObject.tag == "Player1")
                {
                    thisUnitsMovementLogic.canWalk = true;
                    thisUnitsMovementLogic.canAttack = false;
                }
            }
        }
        #endregion


        #region FriendZone
        if (this.gameObject.name == "Friend Zone")
        {
            if (this.gameObject.tag == "Player1")
            {
                if (other.gameObject.tag == "Player1")
                {
                    thisUnitsMovementLogic.canWalk = true;
                    thisUnitsMovementLogic.canIdle = false;
                }
            }
            if (this.gameObject.tag == "Player2")
            {
                if (other.gameObject.tag == "Player2")
                {
                    thisUnitsMovementLogic.canWalk = true;
                    thisUnitsMovementLogic.canIdle = false;
                }
            }
        }
        #endregion

    }
    */

}
