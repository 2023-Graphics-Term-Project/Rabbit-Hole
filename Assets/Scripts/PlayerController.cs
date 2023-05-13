using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float xSpeed = xInput * speed;
        Vector3 newVelocity = new Vector3(xSpeed, playerRigidbody.velocity[1], 0f);

        playerRigidbody.velocity = newVelocity;
    }
}
