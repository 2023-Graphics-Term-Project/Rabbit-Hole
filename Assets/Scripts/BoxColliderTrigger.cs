using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderTrigger : MonoBehaviour
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
        string hierarchyPath = GetGameObjectPath(other.gameObject);
        Debug.Log("Player is OnTriggerEnter: " + hierarchyPath);

        GameObject collidingObject = GameObject.Find(hierarchyPath);

        if (collidingObject != null)
        {
            BoxColliderController colliderController = collidingObject.GetComponent<BoxColliderController>();
            colliderController.Deactivate();
        }
    }

    void OnTriggerExit(Collider other)
    {
        string hierarchyPath = GetGameObjectPath(other.gameObject);
        Debug.Log("Player is OnTriggerExit: " + hierarchyPath);

        GameObject collidingObject = GameObject.Find(hierarchyPath);

        if (collidingObject != null)
        {
            BoxColliderController colliderController = collidingObject.GetComponent<BoxColliderController>();
            colliderController.Activate();
        }
    }

    //reference: http://egloos.zum.com/foodybug/v/4163157
    public static string GetGameObjectPath(GameObject obj)
    {
        string path = "/" + obj.name;
        while (obj.transform.parent != null)
        {
            obj = obj.transform.parent.gameObject;
            path = "/" + obj.name + path;
        }
        return path;
    }

}
