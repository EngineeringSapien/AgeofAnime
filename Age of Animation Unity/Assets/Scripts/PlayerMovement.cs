using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour {

    public Animator animator;

    public float speed = .5f;

    private bool canWalk;
    private bool canIdle;
    public bool canMeleeAttack;
    public bool canRangeAttack;


    void Start ()
    {
        canWalk = true;

        if (gameObject.gameObject.tag == "Player2") { FlipUnit(); }
    }


    void Update ()
    {
        animator.SetBool("isAttacking", false);
        animator.SetBool("isFiring", false);

        if (canWalk == true) { MakePlayerWalk(); }

        else { animator.SetBool("isWalking", false); }

        if (canIdle == true) { MakePlayerIdle(); }

        else { animator.SetBool("isIdle", false); }

        Debug.Log("Tag: " + gameObject.gameObject.tag);
    }


    void FlipUnit()
    {
        transform.Rotate(0f, 180f, 0f);
    }


    void MakePlayerWalk()
    {
        animator.SetBool("isWalking", true);
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }


    void MakePlayerIdle()
    {
        animator.SetBool("isIdle", true);
    }


    public void WalkTrue()
    {
        canWalk = true;
        canIdle = false;
        canMeleeAttack = false;
        canRangeAttack = false;
    }


    public void IdleTrue()
    {
        canWalk = false;
        canIdle = true;
        canMeleeAttack = false;
        canRangeAttack = false;
    }


    public void AttackTrue()
    {
        canWalk = false;
        canIdle = false;
        canMeleeAttack = true;
        canRangeAttack = false;
    }


    public void FireTrue()
    {
        canWalk = false;
        canIdle = false;
        canMeleeAttack = false;
        canRangeAttack = true;
    }

}
