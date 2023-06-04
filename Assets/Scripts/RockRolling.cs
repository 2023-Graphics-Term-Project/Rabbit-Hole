using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockRolling : MonoBehaviour
{
    private Rigidbody rigid;
    private float maxMagnitude = 5.0f;
    private float volume = 0.0f;
    private bool isGameStop = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        AudioManager.Instance.PlayBG("RollingStone");
    }

    // Update is called once per frame
    void Update()
    {
        float magnitude = rigid.velocity.magnitude > 5.0f ? 5.0f : rigid.velocity.magnitude;
        volume = magnitude / maxMagnitude;
        IsGameStop();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Map") && !isGameStop)
        {
            AudioManager.Instance.PlaySFX("RockSmash");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.CompareTag("Map") && !isGameStop)
        {
            AudioManager.Instance.ControlBG(volume);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.CompareTag("Map") && !isGameStop)
        {
            AudioManager.Instance.ControlBG(0.0f);
        }
    }

    private void IsGameStop()
    {
        isGameStop = GameObject.Find("RabbitWrapper").GetComponent<GameStop>().isGameEnd;
    }
}
