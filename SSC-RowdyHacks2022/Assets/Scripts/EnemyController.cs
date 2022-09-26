using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameController gameController;
    [SerializeField] private int health = 5;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            // set health to zero
            health = 0;
            // destroys enemy
            Destroy(gameObject);
            // add score
            gameController.score += 5;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if enemy gets hit by bullet, enemy loses health
        if (other.gameObject.tag == "Bullet")
        {
            health -= 1;
        }
    }
}
