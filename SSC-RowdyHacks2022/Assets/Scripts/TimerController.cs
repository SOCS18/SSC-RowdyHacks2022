using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] private float timer = 5;               // set amount of seconds in timer
    [SerializeField] private bool isCountingDown = false;   // checking whether or not timer is counting down
    public GameController gameController;                   // borrowing elements from GameController script
    public GameObject endMenu;
    public Text timerText;
    public Text finalScoreText;

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
            // if timer isn't at zero, it'll decrease the time
            if (timer > 0)
            {
                timer -= Time.deltaTime;    // decreases timer by 1 each second
            }
            else
            {
                DisplayEndMenu();           // calls method that has end menu pop up
                isCountingDown = false;
            }
        }

        // will be displaying timer to text
        timerText.text = "Time: " + (int)timer;
    }

    void DisplayEndMenu()
    {
        endMenu.SetActive(true);
        Time.timeScale = 0f;
        if (gameController.score == 0)
            finalScoreText.text = "Oh No!\nYou didn't destroy the capsule!";
        else
            finalScoreText.text = "Congratulations!\nYou destroyed the capsule";
    }
}
