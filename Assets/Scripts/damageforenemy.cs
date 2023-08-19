using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damageforenemy : MonoBehaviour
{
    public int health = 100;
    public Animator animator;
    public Slider healthBar;
    public ParticleSystem particle;



    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        healthBar.value = health;
    }
    

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            animator.SetTrigger("isDead");
            animator.SetBool("isAttacking", false);
            animator.SetBool("isChasing", false);
            animator.SetBool("isWalking", false);
            enemyAnimationControlling.isdead = true;
            GetComponent<Rigidbody>().isKinematic = false;
           
        }
        else
        {
            animator.SetTrigger("isDamage");
            particle.Play();
            
        }

    }
    
}
