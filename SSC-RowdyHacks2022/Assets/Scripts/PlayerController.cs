using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    
    public GameObject projectile;
    public Transform startProjectile;
    [SerializeField] private float projSpeed = 375f;
    
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
        leftRightMovement = Input.GetAxis("Horizontal");
        upDownMovement = Input.GetAxis("Vertical");

        transform.Translate(leftRightMovement * playerSpeed * Time.deltaTime, 0, 0);
        transform.Translate(0, 0, upDownMovement * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pew");

            GameObject bullet;
            bullet = Instantiate(projectile, startProjectile.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.right * projSpeed);
        }

    }
}
