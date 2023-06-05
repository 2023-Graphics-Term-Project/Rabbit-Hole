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

    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindWithTag("RabbitAnimator").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
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

    public void Restartmap(){
        Debug.Log("click");
        SceneManager.LoadScene("Map3");
        GameOver.SetActive(false);
        isGameEnd = false;
        // animator.SetTrigger("RabbitAnimator");
        
    }
    public void GameExit(){
        Application.Quit();
        Debug.Log("click");
    }

}
