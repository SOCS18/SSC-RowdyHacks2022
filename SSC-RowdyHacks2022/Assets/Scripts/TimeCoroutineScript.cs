using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCoroutineScript : MonoBehaviour
{
    [SerializeField] private bool isPaused;
    public float cooldownTimer = 5;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Time.timeScale = 1;
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0;
                isPaused = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(StartCooldown());
        }
    }

    public IEnumerator StartCooldown()
    {
        Debug.Log("Cooldown Start");
        yield return new WaitForSeconds(cooldownTimer);
        Debug.Log("Cooldown End");
    }
}
