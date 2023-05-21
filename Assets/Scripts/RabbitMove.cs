using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMove : MonoBehaviour
{
    CharacterController controller;
    new Transform transform;
    Animator animator;

    public float moveSpeed = 0.2f;
    float yVelocity = 0;
    float gravity = -0.0002f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
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
    float v => Input.GetAxis("Vertical");

    void Move()
    {
        Vector3 moveDir = new Vector3(0.0f, 0.0f, 0.0f); // controller.transform.position;

        yVelocity += gravity * Time.deltaTime;
        moveDir.y = yVelocity;
        moveDir.x = h * moveSpeed * Time.deltaTime;

        if(controller.isGrounded) {
            yVelocity = 0;
        }

        controller.Move(moveDir);
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
