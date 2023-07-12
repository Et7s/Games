using System.Collections;
using System.Collections.Generic;
using System.Healths;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == collisionTag)
        {
            PlayerHP health = coll.gameObject.GetComponent<PlayerHP>();
            health.TakeHit(collisionDamage);
        }
    }
}
