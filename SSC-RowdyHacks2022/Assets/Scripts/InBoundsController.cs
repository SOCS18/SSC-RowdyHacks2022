using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBoundsController : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private float screenWidth = 8.3f;
    [SerializeField] private float screenHeight = 4.4f;
    [SerializeField] private float playerXPos;
    [SerializeField] private float playerZPos;
    
    // Start is called before the first frame update
    void Start()
    {
        // assign player to player GameObject
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // assign player x and z position to appropriate variables
        playerXPos = player.transform.position.x;
        playerZPos = player.transform.position.z;

        // if player moves outside set boundaries, it'll be stopped in its place
        if (playerXPos > screenWidth)
        {
            player.transform.position = new Vector3(screenWidth, player.transform.position.y, player.transform.position.z);
        }

        if (playerZPos > screenHeight)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, screenHeight);
        }

        if (playerXPos < -screenWidth)
        {
            player.transform.position = new Vector3(-screenWidth, player.transform.position.y, player.transform.position.z);
        }

        if (playerZPos < -screenHeight)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -screenHeight);
        }
    }
}
