using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol4 : StateMachineBehaviour
{
    float timer;
    List<Transform> Cu = new List<Transform>();
    NavMeshAgent agent;

    Transform player;
    float chaseRange = 10;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        Transform TargetObject = GameObject.FindGameObjectWithTag("Cu").transform;
        foreach (Transform t in TargetObject)
            Cu.Add(t);

        agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(Cu[0].position);

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
            agent.SetDestination(Cu[Random.Range(0, Cu.Count)].position);

        timer += Time.deltaTime;
        if (timer > 10)
        {
            animator.SetBool("IsPatrolling", false);
        }

        float distance = Vector3.Distance(animator.transform.position, player.position);
        if (distance < chaseRange)
        {
            animator.SetBool("IsChasing", true);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
    }
}
