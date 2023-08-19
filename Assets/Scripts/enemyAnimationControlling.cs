using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAnimationControlling : MonoBehaviour
{
    public float attackRange = 1f;
    public float chaseRange = 7f;
    public static bool isdead = false;

    void Start()
    {
       
    }
    private void Update()
    {
        if(isdead)
        {
            return;
        }
        float distance = Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position);
        if (distance < attackRange)
        {
            GetComponent<Animator>().SetBool("isAttacking", true);
            GetComponent<Animator>().SetBool("isChasing", false);
            GetComponent<Animator>().SetBool("isWalking", false);
        }
        else if (distance < chaseRange)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
            GetComponent<Animator>().SetBool("isChasing", true);
            GetComponent<Animator>().SetBool("isWalking", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
            GetComponent<Animator>().SetBool("isChasing", false);
            GetComponent<Animator>().SetBool("isWalking", true);
        }
    }

}
