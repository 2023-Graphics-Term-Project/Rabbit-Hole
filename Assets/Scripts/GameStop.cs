using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStop : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider trigger)
    {
        if(trigger.tag == "CARROT")
        {
            Destroy(trigger.gameObject);
        }
        if(trigger.tag == "DEATH")
        {
            animator.SetTrigger("Dead");
        }
    }

}
