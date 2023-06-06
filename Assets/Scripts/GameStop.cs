using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStop : MonoBehaviour
{
    Animator animator;
    public bool isGameEnd = false;
    public GameObject GameOver;
    public GameObject RabbitWrapper;
    public float rabbitposition = 10;

    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindWithTag("RabbitAnimator").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       rabbitposition = RabbitWrapper.transform.position.y;
        Debug.Log(RabbitWrapper.transform.position.y);
        
        if(rabbitposition < -10 && !isGameEnd){
            isGameEnd = true;
            
            animator.SetTrigger("Dead");
            
            AudioManager.Instance.PauseBG();
            AudioManager.Instance.PauseMusic();
            AudioManager.Instance.PlaySFX("Death");
            GameOver.SetActive(true);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("DEATH") && !isGameEnd)
        {
            isGameEnd = true;
            
            animator.SetTrigger("Dead");
            
            AudioManager.Instance.PauseBG();
            AudioManager.Instance.PauseMusic();
            AudioManager.Instance.PlaySFX("Death");

            CameraZoom cameraZoom = Camera.main.GetComponent<CameraZoom>();
            if (cameraZoom != null)
            {
                cameraZoom.StartZoom();
            }
            GameOver.SetActive(true);
        }
        
    }
}
