using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Animator animator;

    public float speed = .5f;

    public bool canWalk;
    public bool canAttack;
    public bool canIdle;
    public bool canFire;
    bool triggered = false;


    Collider2D collision;



    void Start ()
    {
        canWalk = true;

        if (gameObject.gameObject.tag == "Player2")
        {
            transform.Rotate(0f, 180f, 0f);
        }
    }


    void Update ()
    {
        animator.SetBool("isAttacking", false);
        animator.SetBool("isFiring", false);

        if (canWalk == true)
        {
            playerWalk();
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (canIdle == true)
        {
            animator.SetBool("isIdle", true);
        }
        else
        {
            animator.SetBool("isIdle", false);
        }
    }


    void playerWalk()
    {
        animator.SetBool("isWalking", true);
        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }

    public void WalkTrue()
    {
        canWalk = true;
        canIdle = false;
        canAttack = false;
        canFire = false;
    }

    public void IdleTrue()
    {
        canWalk = false;
        canIdle = true;
        canAttack = false;
        canFire = false;
    }

    public void AttackTrue()
    {
        canWalk = false;
        canIdle = false;
        canAttack = true;
        canFire = false;
    }

    public void FireTrue()
    {
        canWalk = false;
        canIdle = false;
        canAttack = false;
        canFire = true;
    }





    /*void OnTriggerStay2D(Collider2D collision)
    {
        triggered = true;
        this.collision = collision;

        if (gameObject.gameObject.tag == "Player1")
        {
            if (collision.gameObject.tag == "Player2")
            {
                canWalk = false;
                canAttack = true;    
            }

            if (collision.gameObject.tag == "Player1")
            {
                canWalk = false;
                canIdle = true;
            }

            if (collision.gameObject.tag == "P2Base")
            {
                canWalk = false;
                canAttack = true;
            }
        }
        if (gameObject.gameObject.tag == "Player2")
        {
            if (collision.gameObject.tag == "Player1")
            {
                canWalk = false;
                canAttack = true;    
            }

            if (collision.gameObject.tag == "Player2")
            {
                canWalk = false;
                canIdle = true;
            }

            if (collision.gameObject.tag == "P1Base")
            {
                canWalk = false;
                canAttack = true;
            }
        }
    }



    private RaycastHit2D CheckRayCast(Vector2 Direction)
    {
        Debug.DrawLine(startingPosition, direction, Color.red);
        Debug.Log("yes");
        return Physics2D.Raycast(startingPosition, direction);
    }




    {
        triggered = true;
        this.collision = collision;

        if (gameObject.gameObject.tag == "Player1")
        {
            if (collision.gameObject.tag == "Player2")
            {
                canWalk = false;
                canAttack = true;    
            }

            if (collision.gameObject.tag == "Player1")
            {
                canWalk = false;
                canIdle = true;
            }

            if (collision.gameObject.tag == "P2Base")
            {
                canWalk = false;
                canAttack = true;
            }
        }
        if (gameObject.gameObject.tag == "Player2")
        {
            if (collision.gameObject.tag == "Player1")
            {
                canWalk = false;
                canAttack = true;    
            }

            if (collision.gameObject.tag == "Player2")
            {
                canWalk = false;
                canIdle = true;
            }

            if (collision.gameObject.tag == "P1Base")
            {
                canWalk = false;
                canAttack = true;
            }
        }
    }





    void OnTriggerExit2D(Collider2D other)
    {
        if (gameObject.gameObject.tag == "Player1")
        {
            if (other.gameObject.tag == "Player2")
            {
                canWalk = true;
                canAttack = false;
            }

            if (other.gameObject.tag == "Player1")
            {
                canWalk = true;
                canIdle = false;
            }
        }

        if (gameObject.gameObject.tag == "Player2")
        {   
            if (other.gameObject.tag == "Player1")
            {
                canWalk = true;
                canAttack = false;
            }

            if (other.gameObject.tag == "Player2")
            {
                canWalk = true;
                canIdle = false;
            }
        }
  
    }*/


}
