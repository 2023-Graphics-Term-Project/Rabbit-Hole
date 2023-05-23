using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterRotator : MonoBehaviour
{
    public float rotateSpeed = 0.2f;
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        angle = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            angle -= rotateSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            angle += rotateSpeed;
        }

        transform.localRotation = Quaternion.Euler(10, 0, angle);       
    }
}
