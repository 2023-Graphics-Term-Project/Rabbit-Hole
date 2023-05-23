using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Activate()
    {
        Debug.Log("Activate()");
        BoxCollider collider = GetComponent<BoxCollider>();
        if (collider != null)
        {
            collider.enabled = true;
        }
    }

    public void Deactivate()
    {
        Debug.Log("Dectivate()");
        BoxCollider collider = GetComponent<BoxCollider>();
        if (collider != null)
        {
            collider.enabled = false;
        }
    }
}
