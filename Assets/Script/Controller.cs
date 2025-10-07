using System;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;
    private Animator animator; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Target.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "target")
        {
            animator.SetBool("Attack",true);
            animator.SetBool("Walk",false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "target")
        {
            animator.SetBool("Attack",false);
            animator.SetBool("Walk", true);
        }
    }
}
