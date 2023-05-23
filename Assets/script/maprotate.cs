using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maprotate : MonoBehaviour
{

    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0,0, -this.speed*Time.deltaTime);
            Debug.Log("input left");

        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0,0, this.speed*Time.deltaTime);
            Debug.Log("input right");
        }
    }
}
