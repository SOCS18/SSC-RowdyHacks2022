using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameController gameController;
    public TimerController timerController;
    [SerializeField] private int health = 5;

    public GameObject enemyPrefab;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            EnemyDefeated();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if enemy gets hit by bullet, enemy loses health
        if (other.gameObject.tag == "Bullet")
            health -= 1;
    }

    void EnemyDefeated()
    {
        // set health to zero
        health = 0;

        // destroys enemy
        Destroy(gameObject);

        // add score
        gameController.score += 5;

        // add 1 second to timer
        timerController.timer++;
    }
}
