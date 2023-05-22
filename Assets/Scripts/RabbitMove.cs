using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMove : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    new Transform transform;
    Animator animator;

    public float moveSpeed = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Turn();
        Animate();
    }

    float h => Input.GetAxis("Horizontal");

    void Move()
    {
        playerRigidbody.AddForce(moveSpeed, 0, 0);
    }

    Vector3 turnAngle = new Vector3(0.0f, 180f, 0.0f);
    bool isLeft = false;

    void Turn()
    {
        if (h > 0 && isLeft)
        {
            transform.Rotate(turnAngle);
            isLeft = false;
        }
        else if (h < 0 && !isLeft) 
        {
            transform.Rotate(turnAngle);
            isLeft = true;
        }
    }

    void Animate()
    {
        if(Input.GetButton("Horizontal"))
        {
            animator.SetTrigger("IdleToRun");
        } 
        else {
            animator.SetTrigger("RunToIdle");    
        }
    }

}
