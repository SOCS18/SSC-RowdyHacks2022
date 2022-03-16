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
    
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        player = GameObject.FindGameObjectWithTag("Player");
        playerXPos = player.transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.transform.position);
        if (player.transform.position.x > screenWidth)
        {
            player.transform.position = new Vector3(screenWidth, player.transform.position.y, player.transform.position.z);
        }
        if (player.transform.position.z > screenHeight)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, screenHeight);
        }
        if (player.transform.position.x < -screenWidth)
        {
            player.transform.position = new Vector3(-screenWidth, player.transform.position.y, player.transform.position.z);
        }
        if (player.transform.position.z < -screenHeight)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -screenHeight);
        }
    }
}
