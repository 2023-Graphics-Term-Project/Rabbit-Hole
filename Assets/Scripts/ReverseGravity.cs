using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseGravity : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float forceGravity = 9.8f;
    void FixedUpdate()
    {
       rigid.AddForce(Vector3.up * forceGravity ,ForceMode.Acceleration);
    }
}
