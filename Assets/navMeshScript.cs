using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navMeshScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator animator;


    private void Start()
    {
        animator=animator.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit))
            {
                agent.SetDestination(hit.point);
                animator.SetBool("ismovingfront", true);
            }  
        }

        if (agent.remainingDistance <= 2f)
        {
                animator.SetBool("ismovingfront", false);
        }

    }
}
