using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAnimationController : MonoBehaviour
{
    Animator Animator;
   
    public Transform enemy;


    void Start()
    {
        Animator = GetComponent<Animator>();
        enemy = GameObject.FindGameObjectWithTag("enemy").transform; 

        
    }

    // Update is called once per frame
    void Update()
    {
        //want to move character forward
        
        if (Input.GetKey("w"))
        {
            Animator.SetBool("ismovingfront", true);
        }
        if(!Input.GetKey("w"))
        {
            //Animator.SetBool("ismovingfront", false);
        }
        //by pressing space you can make bool JumpAndAttack true
        if (Input.GetKey("space"))
        {
            Animator.transform.LookAt(enemy);
            Animator.SetBool("isjumpingandAttacking", true);
        }
        //by releasing space you can make bool JumpAndAttack false
        if (!Input.GetKey("space"))
        {
            Animator.SetBool("isjumpingandAttacking", false);
        }
        if(Input.GetKey("s"))
        {
            Animator.SetBool("ismovingback", true);
        }
        if(!Input.GetKey("s"))
        {
            Animator.SetBool("ismovingback", false);
        }
        if(Input.GetKey("f"))
        {
            Animator.transform.LookAt(enemy);
            Animator.SetBool("isfliping", true);
        }
        if(!Input.GetKey("f"))
        {
            Animator.SetBool("isfliping", false);
        }
        if(Input.GetKey("d"))
        {
            Animator.SetBool("isrunningtoright", true);
        }
        if(!Input.GetKey("d"))
        {
            Animator.SetBool("isrunningtoright", false);
        }
        if(Input.GetKey("a"))
        {
            Animator.SetBool("isrunningtoleft", true);
        }
        if(!Input.GetKey("a"))
        {
            Animator.SetBool("isrunningtoleft", false);
        }

        
       

    }
}
