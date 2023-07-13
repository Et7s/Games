using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int Hp = 100;

    [SerializeField]
    private NavMeshAgent agent;

    private Transform target;
    float attackRange = 2;
    public GameObject gameObject;


    private void Start()
    {
       
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        agent.SetDestination(target.position);
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < attackRange)
            Debug.Log("Нанес урон по противнику ");
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
