using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderTriggers : MonoBehaviour {

   /* public PlayerMovement thisCharactersMovementLogic;
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
                    thisCharactersMovementLogic.canWalk = false;
                    thisCharactersMovementLogic.canAttack = true;
                }

                if (collision.gameObject.tag == "P2Base")
                {
                    thisCharactersMovementLogic.canWalk = false;
                    thisCharactersMovementLogic.canAttack = true;
                }
            }

            if (this.gameObject.tag == "Player2")
            {
                if (collision.gameObject.tag == "Player1")
                {
                    thisCharactersMovementLogic.canWalk = false;
                    thisCharactersMovementLogic.canAttack = true;
                }

                if (collision.gameObject.tag == "P1Base")
                {
                    thisCharactersMovementLogic.canWalk = false;
                    thisCharactersMovementLogic.canAttack = true;
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
                    thisCharactersMovementLogic.canWalk = false;
                    thisCharactersMovementLogic.canIdle = true;
                }
            }

            if (this.gameObject.tag == "Player2")
            {
                if (collision.gameObject.tag == "Player2")
                {
                    thisCharactersMovementLogic.canWalk = false;
                    thisCharactersMovementLogic.canIdle = true;
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
                    thisCharactersMovementLogic.canWalk = true;
                    thisCharactersMovementLogic.canAttack = false;
                }
            }
            if (gameObject.gameObject.tag == "Player2")
            {
                if (other.gameObject.tag == "Player1")
                {
                    thisCharactersMovementLogic.canWalk = true;
                    thisCharactersMovementLogic.canAttack = false;
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
                    thisCharactersMovementLogic.canWalk = true;
                    thisCharactersMovementLogic.canIdle = false;
                }
            }
            if (this.gameObject.tag == "Player2")
            {
                if (other.gameObject.tag == "Player2")
                {
                    thisCharactersMovementLogic.canWalk = true;
                    thisCharactersMovementLogic.canIdle = false;
                }
            }
        }
        #endregion

    }
    */

}
