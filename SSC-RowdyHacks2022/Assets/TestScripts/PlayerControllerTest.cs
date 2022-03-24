using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    [SerializeField] private float leftRightMovement;
    [SerializeField] private float upDownMovement;
    [SerializeField] private float playerSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftRightMovement = Input.GetAxis("Horizontal");
        upDownMovement = Input.GetAxis("Vertical");

        // controls player movement
        transform.Translate(leftRightMovement * playerSpeed * Time.deltaTime, 0, 0);
        transform.Translate(0, 0, upDownMovement * playerSpeed * Time.deltaTime);

        //Debug.Log(leftRightMovement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
        }
    }
}
