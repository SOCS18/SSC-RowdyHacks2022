using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] private float timer = 5;
    [SerializeField] private bool isCountingDown = false;
    public GameObject endMenu;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        isCountingDown = true;
        endMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCountingDown)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                DisplayEndMenu();
                isCountingDown = false;
            }
        }

        timerText.text = "Time: " + (int)timer;
    }

    void DisplayEndMenu()
    {
        Debug.Log("Timer is done");
        endMenu.SetActive(true);
    }
}
