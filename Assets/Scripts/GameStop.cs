using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStop : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindWithTag("RabbitAnimator").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider trigger)
    {
        print(trigger.tag);
        if(trigger.tag == "CARROT")
        {
            Destroy(trigger.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.tag);
        if(collision.collider.CompareTag("DEATH"))
        {
            animator.SetTrigger("Dead");
            CameraZoom cameraZoom = Camera.main.GetComponent<CameraZoom>();
            if (cameraZoom != null)
            {
                cameraZoom.StartZoom();
            }
        }
    }

}
