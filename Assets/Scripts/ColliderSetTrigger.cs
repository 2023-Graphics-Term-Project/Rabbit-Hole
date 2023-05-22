using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSetTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.tag == "Player")
        {
            GameObject pillar = GameObject.Find("/Level/IllusionPillar");
            if (pillar != null)
            {
                ColliderController colliderController = pillar.GetComponent<ColliderController>();
                colliderController.Deactivate();

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        if (other.tag == "Player")
        {
            GameObject pillar = GameObject.Find("/Level/IllusionPillar");
            if (pillar != null)
            {
                ColliderController colliderController = pillar.GetComponent<ColliderController>();
                colliderController.Activate();

            }
        }
    }

}
