using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour {

    public Animator animator;
    MovementSoundFX soundFX;

    public float speed = .5f;

    private bool canWalk;
    private bool canIdle;
    public bool canMeleeAttack;
    public bool canRangeAttack;


    void Start ()
    {
        soundFX = gameObject.GetComponent<MovementSoundFX>();

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
    }


    void FlipUnit()
    {
        transform.Rotate(0f, 180f, 0f);
    }


    void MakePlayerWalk()
    {
        animator.SetBool("isWalking", true);
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("ItachiWalk") || animator.GetCurrentAnimatorStateInfo(0).IsName("playerWalk"))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            soundFX.StopSounds();
        }

    }


    void MakePlayerIdle()
    {
        animator.SetBool("isIdle", true);
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("ItachiIdle") || animator.GetCurrentAnimatorStateInfo(0).IsName("playerIdle"))
        {
            soundFX.StopSounds();
        }
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
