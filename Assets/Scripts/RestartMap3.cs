using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMap3 : MonoBehaviour
{
    public GameObject Gameoverset;

    public void Restartmap(){
        SceneManager.LoadScene("Map3");
        Gameoverset.SetActive(false);
        Debug.Log("click");
    }
    public void GameExit(){
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
