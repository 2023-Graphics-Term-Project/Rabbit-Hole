using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMove : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    public float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = playerRigidbody.velocity.x;
        float maxSpeed = 1.0f;

        float xInput = Input.GetAxis("Horizontal");

        if (xInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            if (Mathf.Abs(x) <= maxSpeed)
            {
                playerRigidbody.AddForce(xInput * moveSpeed, 0, 0);
            }
        }
        else if (xInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            if (Mathf.Abs(x) <= maxSpeed)
            {
                playerRigidbody.AddForce(xInput * moveSpeed, 0, 0);
            }
        }
        else
        {
            playerRigidbody.AddForce(0.01f, 0, 0);
        }
    }
}
