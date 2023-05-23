using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitAnimController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animate();
        transform.localPosition = new Vector3(0, 0, 0);
    }

    void Animate()
    {
        if (Input.GetButton("Horizontal"))
        {
            animator.SetTrigger("IdleToRun");
        }
        else
        {
            animator.SetTrigger("RunToIdle");
        }
    }
}
