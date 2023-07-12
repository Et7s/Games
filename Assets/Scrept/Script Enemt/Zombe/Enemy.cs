using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int Hp = 100;

    private NavMeshAgent agent;
    private Transform target;
    float attackRange = 2;
    public GameObject gameObject;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        agent.SetDestination(target.position);
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < attackRange)
            Debug.Log("����� ���� �� ���������� ");
    }

    public void SetDamage(int damage)
    {
        Hp -= damage;

        if(Hp <= 0)
        {
            Destroy(gameObject);
                
        }
    }
    
}
