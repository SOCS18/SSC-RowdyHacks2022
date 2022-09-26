using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // projectile is destroyed after colliding with the enemy or game boundary
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Boundary")
            Destroy(gameObject);
    }
}
