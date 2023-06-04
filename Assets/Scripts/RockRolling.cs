using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockRolling : MonoBehaviour
{
    private Rigidbody rigid;
    private float maxMagnitude = 5.0f;
    private float volume = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        AudioManager.Instance.PlaySFX("RollingStone");
    }

    // Update is called once per frame
    void Update()
    {
        float magnitude = rigid.velocity.magnitude > 5.0f ? 5.0f : rigid.velocity.magnitude;
        Debug.Log(magnitude);
        volume = magnitude / maxMagnitude;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Map"))
        {
            AudioManager.Instance.PlaySFX("RockSmash");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.CompareTag("Map"))
        {
            AudioManager.Instance.controlSFX("RollingStone", volume);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.CompareTag("Map"))
        {
            AudioManager.Instance.controlSFX("RollingStone", 0.0f);
        }
    }
}
