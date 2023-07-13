using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Zombe_spawn : MonoBehaviour
{
    public GameObject Zombe;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Zombe.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
       
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
