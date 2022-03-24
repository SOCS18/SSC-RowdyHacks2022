using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Text finalScoreText;
    public GameObject endMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        endMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // assign score integer to appropriate text
        scoreText.text = "Score:\n" + score;

        if (score > 0)
        {
            DisplayEndMenu();
        }
    }

    void DisplayEndMenu()
    {
        endMenu.SetActive(true);
        finalScoreText.text = "Congratulations!\nYou destroyed the capsule";
    }
}
