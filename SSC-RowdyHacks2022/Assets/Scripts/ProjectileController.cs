using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // projectile is destroyed after colliding with the enemy or game boundary
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Boundary")
            Destroy(gameObject);
    }
}
