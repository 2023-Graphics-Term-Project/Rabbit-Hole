using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoleManager : MonoBehaviour
{
    public bool playerHasCarrot = false;
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
        if (other.CompareTag("Player"))
        {
            PassLevel();
        }
    }

    public void PassLevel()
    {
        if (!playerHasCarrot)
        {
            return;
        }

        AudioManager.Instance.PlaySFX("EnterHole");
        
        if (SceneManager.GetActiveScene().name == "Map1")
        {
            SceneManager.LoadScene("Map2");
        }
        else if (SceneManager.GetActiveScene().name == "Map2")
        {
            SceneManager.LoadScene("Map3");
        }
    }
}
