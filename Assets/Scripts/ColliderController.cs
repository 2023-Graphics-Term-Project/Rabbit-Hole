using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
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
        Collider collider = GetComponent<BoxCollider>();
        if (collider != null)
        {
            collider.enabled = true;
        }
    }

    public void Deactivate()
    {
        Collider collider = GetComponent<BoxCollider>();
        if (collider != null)
        {
            collider.enabled = false;
        }
    }
}
