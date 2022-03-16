using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBoundsController : MonoBehaviour
{
    public Camera mainCam;
    public GameObject player;
    [SerializeField] private float screenWidth = 8.3f;
    [SerializeField] private float screenHeight = 4.4f;
    [SerializeField] private float playerXPos;
    [SerializeField] private float playerZPos;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        player = GameObject.FindGameObjectWithTag("Player");
        playerXPos = player.transform.position.x;
        playerZPos = player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.transform.position);
        if (playerXPos > screenWidth)
        {
            player.transform.position = new Vector3(screenWidth, player.transform.position.y, playerZPos);
        }
        if (playerZPos > screenHeight)
        {
            player.transform.position = new Vector3(playerXPos, player.transform.position.y, screenHeight);
        }
        if (playerXPos < -screenWidth)
        {
            player.transform.position = new Vector3(-screenWidth, player.transform.position.y, playerZPos);
        }
        if (playerZPos < -screenHeight)
        {
            player.transform.position = new Vector3(playerXPos, player.transform.position.y, -screenHeight);
        }
    }
}
