using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = playerRigidbody.velocity.x;
        float y = playerRigidbody.velocity.y;
        float z = playerRigidbody.velocity.z;
        float maxSpeed = 2f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            if (Mathf.Abs(x) <= maxSpeed)
            {
                playerRigidbody.AddForce(speed, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            if (Mathf.Abs(x) <= maxSpeed)
            {
                playerRigidbody.AddForce(-speed, 0, 0);
            }
        }
    }
}
