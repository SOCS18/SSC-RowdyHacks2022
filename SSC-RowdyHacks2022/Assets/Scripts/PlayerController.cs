using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    
    // projectile variables
    public GameObject projectile;
    public Transform startProjectile;
    [SerializeField] private float projSpeed = 375f;
    
    // player movement variables
    [SerializeField] private float leftRightMovement;
    [SerializeField] private float upDownMovement;
    [SerializeField] private float playerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // player movement detector
        leftRightMovement = Input.GetAxis("Horizontal");
        upDownMovement = Input.GetAxis("Vertical");

        // controls player movement
        transform.Translate(leftRightMovement * playerSpeed * Time.deltaTime, 0, 0);
        transform.Translate(0, 0, upDownMovement * playerSpeed * Time.deltaTime);

        // shooter detector
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // creates bullet
            GameObject bullet = Instantiate(projectile, startProjectile.position, Quaternion.identity);

            // moves bullet across the screen
            bullet.GetComponent<Rigidbody>().AddForce(transform.right * projSpeed);
        }

    }
}
